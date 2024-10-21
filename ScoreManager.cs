using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Player's current score
    public TextMeshProUGUI scoreText; // Reference to a TextMeshProUGUI object to display the score

    // Method to increase score
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreDisplay();
    }

    // Method to decrease score (optional, in case you want penalties)
    public void SubtractScore(int amount)
    {
        score -= amount;
        if (score < 0) score = 0; // Keep score from going negative
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}
