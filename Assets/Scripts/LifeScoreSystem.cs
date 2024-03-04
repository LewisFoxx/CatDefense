using TMPro;
using UnityEngine;

public class LifeScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI roundText;
    public bool hasPlayerFailed = false; // whether the player has lost the game or not
    private int lives = 1;
    private int money = 650;
    private int round = 0;

    public int moneyIncreasePerRound = 101;
    public int moneyIncreasePerKill = 1;

    void Start()
    {
        // Initialize text
        UpdateLivesUI();
        UpdateMoneyUI();
        UpdateRoundUI();
    }

    public void DecreaseLives()
    {
        if (lives > 0)
        {
            lives--;
            UpdateLivesUI();
        }
        
        // If lives reach 0 then call the gameOver function, displaying the gameover screen
        if (lives <= 0)
        {
            // Call gameOver() in RoundManager
            FindObjectOfType<RoundManager>().gameOver();
            hasPlayerFailed = true;
}
    }

    private void UpdateLivesUI()
    {
        lifeText.text = "Lives: " + lives;
    }
    public void GiveRoundMoney()
    {
        if (money > 0)
        {
            money += moneyIncreasePerRound;
            UpdateMoneyUI();
        }
        
    }

    public void GiveKillMoney()
    {
        if (money > 0)
        {
            money += moneyIncreasePerKill;
            UpdateMoneyUI();
        }  
    }

    private void UpdateMoneyUI()
    {
        moneyText.text = "Money: " + money;
    }
    private void UpdateRoundUI()
    {
        roundText.text = "Round: " + round;
    }
    public void IncreaseRound()
    {
        round++;
        UpdateRoundUI();
    }
}
