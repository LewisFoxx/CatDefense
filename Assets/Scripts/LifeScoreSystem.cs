using TMPro;
using UnityEngine;

public class LifeScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI roundText;
    private int lives = 40;
    private int money = 650;

    void Start()
    {
        // Initialize the life text
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
        money++;
        UpdateMoneyUI();
    }

    private void UpdateMoneyUI()
    {
        moneyText.text = "Money: " + money;
    }
}
