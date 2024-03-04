using UnityEngine;
using UnityEngine.UI;

public class StartRoundButton : MonoBehaviour
{
    public EnemySpawner enemySpawner;  // Reference to the EnemySpawner script
    private Button button;  // Reference to the Button component

    void Start()
    {
        // Get the button component and add a listener to the click event
        button = GetComponent<Button>();
        button.onClick.AddListener(StartRound);
    }

    void Update()
    {
        // Disable the button while the round is ongoing
        if (enemySpawner.roundOngoing)
        {
            button.interactable = false;
        }
        else
        {
            // Enable the button when the round has ended
            button.interactable = true;
        }
    }

    public void StartRound()
    {
        // Only start the next round if a round is not currently ongoing
        if (!enemySpawner.roundOngoing)
        {
            enemySpawner.roundStart = true;
            // Immediately disable the button
            button.interactable = false;
        }
    }
}
