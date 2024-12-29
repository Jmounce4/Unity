using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Speed of the player (can be adjusted in the Inspector)

    private PlayerPhysics playerPhysics;

    void Start()
    {
        playerPhysics = GetComponent<PlayerPhysics>(); // Get the PlayerPhysics component
    }

    void Update()
    {
        // Get input for movement (WASD or arrow keys)
        float horizontal = Input.GetAxis("Horizontal"); // Left/Right movement (A/D or Arrow Keys)
        float vertical = Input.GetAxis("Vertical"); // Up/Down movement (W/S or Arrow Keys)

        // Send movement input to PlayerPhysics to handle the movement and sprite flipping
        playerPhysics.MovePlayer(horizontal, vertical);
    }
}