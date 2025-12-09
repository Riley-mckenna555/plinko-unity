using UnityEngine;

public class ExampleCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Not sure why, but "collider" is the other object, and
        // "otherCollider" is this object.
        // Anyway, we check for the player tag and only run if it is a player tagged object.
        // Tag is set in the Inspector in Unity.
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit the player");
            Player playerScript = collision.collider.gameObject.GetComponent<Player>();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
