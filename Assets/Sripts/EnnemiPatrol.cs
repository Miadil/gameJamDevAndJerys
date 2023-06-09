using UnityEngine;

public class EnnemiPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    public SpriteRenderer graphics; 

    private Transform target;
    private int destPoint = 0;

     void Start()
    {
        target = waypoints[0];
    }

    // Update is called once p er frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        // SI L'ENNEMI EST QUASIMENT ARRIVÉ À ÇA DESTINATION
        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
            graphics.flipX = !graphics.flipX;
        }
    }
}
