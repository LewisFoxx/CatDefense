using UnityEngine;
using UnityEngine.UI;

public class StartRoundButton : MonoBehaviour
{
    // Reference to the RoundManager script
    public RoundManager roundManager;

    // Reference to the Button component
    private Button button;

    void Start()
    {
        // Get the Button component
        button = GetComponent<Button>();

        // Add a click listener to the button
        button.onClick.AddListener(StartRound);
    }

    void Update()
    {
        // Make the button interactable when roundStart is false, uninteractable when roundOngoing is true
        button.interactable = !roundManager.roundOngoing && roundManager != null;
    }

    public void StartRound()
    {
        // Set roundStart to true when the button is clicked
        roundManager.roundStart = true;
    }
}