using UnityEngine;
using UnityEngine.UI;

public class GuestBehavior : MonoBehaviour
{
    public Button yesButton;
    public Button noButton;
    public bool isZombie;
    public Timer timer;
    public ScoreManager scoreManager;
    public float penaltyAmount = 5f;
    public int scoreReward = 10;
    public GuestMovement guestMovement;
    public SpriteRandomizer spriteRandomizer;

    void Start()
    {
        // Add listeners to the buttons programmatically
        yesButton.onClick.AddListener(AllowEntry);
        noButton.onClick.AddListener(DenyEntry);

        // Start with a new guest
        RespawnGuest();
    }

    public void AllowEntry()
    {
        if (isZombie)
        {
            Debug.Log("You let a zombie in! Wrong choice!");
            timer.ApplyTimePenalty(penaltyAmount);
        }
        else
        {
            Debug.Log("You let a human in. Good job!");
            scoreManager.AddScore(scoreReward);
        }
        RespawnGuest();
    }

    public void DenyEntry()
    {
        if (isZombie)
        {
            Debug.Log("You denied a zombie. Well done!");
            scoreManager.AddScore(scoreReward);
        }
        else
        {
            Debug.Log("You denied a human! Wrong choice!");
            timer.ApplyTimePenalty(penaltyAmount);
        }
        RespawnGuest();
    }

    void RespawnGuest()
    {
        Debug.Log("Respawning guest...");
        transform.position = new Vector3(-10f, transform.position.y, 0f); // Reset position to off-screen left
        isZombie = Random.Range(0, 2) == 0;

        if (spriteRandomizer != null)
        {
            spriteRandomizer.RandomizeAppearance(); // Randomize the guest's appearance
            Debug.Log("SpriteRandomizer called.");
        }
        else
        {
            Debug.LogError("SpriteRandomizer is not assigned.");
        }

        guestMovement.StartMoving(); // Start moving the guest into the scene again
    }

}
