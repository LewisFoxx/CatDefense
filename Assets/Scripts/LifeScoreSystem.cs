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

    void Start()
    {
        // Initialize text
        UpdateLivesUI();
        UpdateMoneyUI();
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
    public void IncreaseMoney()
    {
        money += moneyIncreasePerRound;
        UpdateMoneyUI();
    }

    private void UpdateMoneyUI()
    {
        moneyText.text = "Money: " + money;
    }

    public void IncreaseRound()
    {

    }
}
