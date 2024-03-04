using TMPro;
using UnityEngine;

public class LifeScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI roundText;
    private int lives = 40;
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
        lives--;
        UpdateLivesUI();
    }

    private void UpdateLivesUI()
    {
        lifeText.text = "Lives: " + lives;
    }
    public void GiveRoundMoney()
    {
        money += moneyIncreasePerRound;
        UpdateMoneyUI();
    }

    public void GiveKillMoney()
    {
        money += moneyIncreasePerKill;
        UpdateMoneyUI();
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
