using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float spawnDelay = 0.5f;
    public float enemyWaveIncrease;
    private int waveIndex = 0;

    // Whether round has started
    public bool roundStart = false;

    // Whether a round is ongoing
    public bool roundOngoing = false;

    // Whether a round has ended
    public bool roundEnd = false;

    // Number of enemies spawned
    public static int enemiesSpawned = 0;

    void Update()
    {
        // Only start the next wave if the next round has started and a wave is not currently being spawned
        if (roundStart)
        {
            StartCoroutine(SpawnWave());
            roundStart = false;
            roundEnd = false;
        }

        // Check if all enemies have been destroyed
        if (enemiesSpawned == EnemyMovement.enemiesDestroyed)
        {
            roundEnd = true;
            enemiesSpawned = 0;
            EnemyMovement.enemiesDestroyed = 0;
        }
    }

    IEnumerator SpawnWave()
    {
        roundOngoing = true;

        int numberOfEnemies = waveIndex == 0 ? 10 : (int)(enemyWaveIncrease * waveIndex);

        for (int i = 0; i < numberOfEnemies; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnDelay);
        }

        waveIndex++;
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        enemiesSpawned++;
    }
}
