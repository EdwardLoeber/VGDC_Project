using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f; // Set the initial time (60 seconds)
    public TextMeshProUGUI timeText; // Reference to a TextMeshProUGUI object to display the timer
    public bool isGameActive = true; // Whether the game is running

    void Update()
    {
        if (isGameActive && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimeDisplay();
        }
        else if (timeRemaining <= 0)
        {
            EndGame();
        }
    }

    void UpdateTimeDisplay()
    {
        // Format the time to display only seconds (no decimals)
        timeText.text = Mathf.Ceil(timeRemaining).ToString() + "s";
    }

    public void ApplyTimePenalty(float penaltyAmount)
    {
        timeRemaining -= penaltyAmount;
        if (timeRemaining < 0)
        {
            timeRemaining = 0;
        }
    }

    void EndGame()
    {
        isGameActive = false;
        Debug.Log("Time's up! Game Over.");
        // Add logic here for what happens when the game ends
    }
}
