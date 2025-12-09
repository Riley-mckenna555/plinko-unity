using UnityEngine;

public class bombbehaviour : MonoBehaviour
{

    public GameObject BombPrefab;
    public string TargetTag = "Peg";

    public void bombupdate()
    {
        //pressable key to detonate
        if (Input.GetButtonDown("fire3"))
        {

            DuplicateBomb();
            Destroy(BombPrefab);
        }
    }


    // Update is called once per frame
    void DuplicateBomb()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject Bomb = Instantiate(BombPrefab, transform.position, Quaternion.identity);

            Rigidbody rb = Bomb.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector2 direction = Random.insideUnitCircle.normalized;
                rb.AddForce(direction * 5f);
            }
        }
    }
}
