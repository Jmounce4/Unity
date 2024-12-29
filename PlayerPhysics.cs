using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private PlayerController playerController; // Reference to PlayerController

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
        playerController = GetComponent<PlayerController>(); // Get the PlayerController component
        rb.freezeRotation = true;
    }

    public void MovePlayer(float horizontal, float vertical)
    {
        // Access speed from PlayerController instance
        float speed = playerController.speed;

        // Apply velocity to move the player
        Vector2 movement = new Vector2(horizontal, vertical) * speed;
        rb.linearVelocity = movement;

        // Flip the sprite based on movement direction (left or right)
        if (horizontal < 0)
        {
            spriteRenderer.flipX = true; // Flip sprite when moving left
        }
        else if (horizontal > 0)
        {
            spriteRenderer.flipX = false; // Flip sprite back when moving right
        }
    }
}
