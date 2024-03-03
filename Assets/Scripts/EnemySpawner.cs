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

    // Whether next round has started
    public bool nextRoundStarted = false;

    void Update()
    {
        // Only start the next wave if the next round has started
        if (nextRoundStarted)
        {
            StartCoroutine(SpawnWave());
            nextRoundStarted = false;  // Reset for the next round
        }
    }

    IEnumerator SpawnWave()
    {
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
    }
}
