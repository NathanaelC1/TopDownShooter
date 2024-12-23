using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter instance;
    public TextMeshProUGUI scoreText;

    private int currentScore = 0;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + currentScore;
    }
}
