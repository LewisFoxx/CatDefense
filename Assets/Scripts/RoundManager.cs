using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundManager : MonoBehaviour
{
    // Reference to the EnemySpawner script
    public EnemySpawner enemySpawner;

    //Reference to the gameover screen
    public GameObject gameOverScreen;

    public bool roundStart = false; // Whether round has started
    public bool roundOngoing = false; // Whether a round is ongoing
    public int currentRound = 0; // Current round number
    private bool wasRoundOngoing = false; // Previous round status
    


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

            // Increase round number
            FindObjectOfType<LifeScoreSystem>().IncreaseRound();
        }

        // If a round just finished, increase player money
        if (wasRoundOngoing && !roundOngoing)
        {
            FindObjectOfType<LifeScoreSystem>().GiveRoundMoney();
        }

        // Update wasRoundOngoing
        wasRoundOngoing = roundOngoing;
    }

    //Game over screen functionality
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
