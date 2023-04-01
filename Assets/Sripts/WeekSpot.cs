using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class WeekSpot : MonoBehaviour
{
    public GameObject objectToDestroy;
    public Animator animator;
    public bool isDead;

    private void Start()
    {
        animator = transform.parent.GetComponent<Animator>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isDead = true;
            //Destroy(transform.parent.parent.gameObject);
            //animator.SetTrigger("isHit");
            animator.SetBool("isDest", isDead);
            StartCoroutine("KillSwitch");
            //Destroy(objectToDestroy);

        }
    }
    IEnumerator KillSwitch()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(objectToDestroy);
    }
}
