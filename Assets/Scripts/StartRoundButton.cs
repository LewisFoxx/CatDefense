using UnityEngine;
using UnityEngine.UI;

public class StartRoundButton : MonoBehaviour
{
    public EnemySpawner enemySpawner;  // Reference to the EnemySpawner script

    void Start()
    {
        // Get the button component and add a listener to the click event
        Button button = GetComponent<Button>();
        button.onClick.AddListener(StartRound);
    }

    public void StartRound()
    {
        // Set nextRoundStarted to true in the EnemySpawner script
        enemySpawner.nextRoundStarted = true;
    }
}
