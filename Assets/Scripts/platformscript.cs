using UnityEngine;

public class platformscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform posA, posB;
    public int speed;
    Vector2 targetpos;
    void Start()
    {
        targetpos = posB.position;
    }

    // Update is called once per frame
    void Update()
    {
        // takes the positions from A + B to get the platform to know whats left and right 
        if (Vector2.Distance(transform.position, posA.position) < .1f) targetpos = posB.position;

        if (Vector2.Distance(transform.position, posB.position) < .1f) targetpos = posA.position;

        transform.position = Vector2.MoveTowards(transform.position,targetpos, speed * Time.deltaTime);
    }
}
