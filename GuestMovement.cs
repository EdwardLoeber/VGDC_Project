using UnityEngine;

public class GuestMovement : MonoBehaviour
{
    public Vector3 targetPosition; // Position where the guest should stop
    public float speed = 2f; // Movement speed
    private bool moving = false;

    void Update()
    {
        if (moving)
        {
            // Move the guest toward the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Check if the guest has reached the target position
            if (transform.position == targetPosition)
            {
                moving = false;
            }
        }
    }

    // Method to start the guest movement again (useful for respawning)
    public void StartMoving()
    {
        Debug.Log("Guest is starting to move...");
        moving = true;
        transform.position = new Vector3(-10f, transform.position.y, 0f); // Adjust the starting position as needed
    }
}
