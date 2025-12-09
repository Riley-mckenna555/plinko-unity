using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera camera;
    public GameObject player;
    public GameObject disc;
    public float lerpRate = 0.5f;

    void FixedUpdate()
    {
        Vector3 targetPosition;
        if (disc == null)
        {
            // If no disc, follow player
            targetPosition = player.transform.position;
        }
        else
        {
            // If disc, follow disc
            targetPosition = disc.transform.position;
        }
        // Change these back so we don't modify these values.
        targetPosition.x = camera.transform.position.x;
        targetPosition.z = camera.transform.position.z;

        // Assign camera position part way from current to target position
        camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, lerpRate);
    }

    public void FollowDisc(GameObject disc)
    {
        // Assign input disc to local variable disc.
        // Reference becomes null when the object is destroyed.
        this.disc = disc;
    }
}
