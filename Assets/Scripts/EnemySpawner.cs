using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public RoundManager roundManager;
    public float spawnDelay = 0.5f;
    public float enemyWaveIncrease;
    private int waveIndex = 0;

    // Number of enemies spawned
    public static int enemiesSpawned = 0;

    public IEnumerator SpawnWave()
    {
        roundManager.roundOngoing = true; // Set roundOngoing to true here

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
