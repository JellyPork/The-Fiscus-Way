using UnityEngine;

public class Player : MonoBehaviour
{
    // Controlled variables
    public float moveSpeed = 5f;

    // Components and Classes
    public Rigidbody2D rb;
    public Camera cam;

    // Initialised variables
    Vector2 movement;
    Vector2 mousePos;
    Vector2 lookDir;
    float angle;

    void Update()
    {
        // Movement Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Rotation Input
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        // Apply Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        // Apply Rotation
        lookDir = mousePos - rb.position; // Find the vector from player to mouse
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg; // Calculate the angle
        rb.rotation = angle;
    }
}