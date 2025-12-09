using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public GameObject disc;
    public GameObject BombPrefab;
    public CameraFollow cameraFollow;
    private GameObject activeDisc;
    private GameObject activebomb;

    void Update()
    {
        Move();
        DropDisc();
    }

    void DropDisc()
    {
        // 
        if (Input.GetButtonDown("Fire1") && activeDisc == null)
        {
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            activeDisc = Instantiate(disc, position, rotation);
            cameraFollow.FollowDisc(activeDisc);
        }
    }

    void DropBomb()
    {
        // fire button to drop bomb 
        if (Input.GetButtonDown("Fire2") && activebomb == null)
        {
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            activebomb = Instantiate(BombPrefab, position, rotation);
            cameraFollow.FollowDisc(activebomb);
        }
    }

    void Move()
    {
        // 
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offset = new Vector3(movementX, 0, 0);
        transform.position += offset;
    }
}
