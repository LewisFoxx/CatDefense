using UnityEngine;
using UnityEngine.UI;

public class SpeedUpButton : MonoBehaviour
{

    // Reference to the Button component
    private Button speedUpButton;
    private bool isSpeedingUp = false;

    // How much the game should speed up by
    public float speedUpAmount = 2f;

    void Start()
    {
        // Get the Button component
        speedUpButton = GetComponent<Button>();

        // Add a click listener to the button
        speedUpButton.onClick.AddListener(SpeedUpGame);
    }

    void Update()
    {
       
    }

    public void SpeedUpGame()
    {
        // Toggle isSpeedingUp
        isSpeedingUp = !isSpeedingUp;

        // If isSpeedingUp is true, speed up the game & change the normalColor to the selectedColor
        if (isSpeedingUp)
        {
            Time.timeScale = speedUpAmount;
        }
        // If isSpeedingUp is false, set the game speed back to normal & the color of the button back to normal
        else
        {
            Time.timeScale = 1;
        }
    }
}