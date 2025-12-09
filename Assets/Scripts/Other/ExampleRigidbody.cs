using UnityEngine;

public class ExampleRigidbody : MonoBehaviour
{
    public float forceN = 1;
    Rigidbody2D rb;
    Vector2 initialPosition;
    float initialRotation;


    private void Start()
    {
        // Dynamically get Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();

        // Record object initial state
        initialPosition = rb.position;
        initialRotation = rb.rotation;
    }

    // For one-time physics events (eg. tied to one-off input events) we use Update.
    // However, for continuous input, we should use FixedUpdate.
    void Update()
    {
        // Draw a debug line from player to player + 1 unit in local up direction
        Debug.DrawLine(transform.position, transform.position + transform.up, Color.green);

        // Player "jump" in local up direction
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 direction = transform.up;
            Vector2 force = direction * forceN;
            rb.AddForce(force, ForceMode2D.Impulse);
        }

        // Player reset
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Move using Rigidbody2D functions
            rb.MovePosition(initialPosition);
            rb.MoveRotation(initialRotation);
        }

    }
}
