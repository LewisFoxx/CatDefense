using UnityEngine;

public class RoundManager : MonoBehaviour
{
    // Reference to the EnemySpawner script
    public EnemySpawner enemySpawner;

    // Whether round has started
    public bool roundStart = false;

    // Whether a round is ongoing
    public bool roundOngoing = false;

    // Current round number
    public int currentRound = 0;

    // Previous round status
    private bool wasRoundOngoing = false;

    // Update is called once per frame
    void Update()
    {
        // Find all game objects with the "Enemy" tag
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // If there are any enemies, set roundOngoing to true
        if (enemies.Length > 0)
        {
            roundOngoing = true;
        }

        // If there are no enemies, set roundOngoing to false
        else
        {
            roundOngoing = false;
        }

        // If roundStart is true and round is not ongoing, start spawning enemies
        if (roundStart && !roundOngoing)
        {
            enemySpawner.StartCoroutine(enemySpawner.SpawnWave());
            roundStart = false;
            currentRound++;
        }

        // If a round just finished, increase money
        if (wasRoundOngoing && !roundOngoing)
        {
            FindObjectOfType<LifeScoreSystem>().IncreaseMoney();
        }

        // Update wasRoundOngoing
        wasRoundOngoing = roundOngoing;
    }
}
