using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 0.05f;

    void Start()
    {
      Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.Translate(0f, 0f, Speed);
    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Player")
        //{
        //    other.GetComponent<PlayerHealth>().Die();
        //}
        //PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        //if (playerHealth != null)
        //{
        //    playerHealth.Die();
        //}
        // ?. 연산자
        // (expression)?. ~ : expression이 null이 아니면 멤버에 접근함.
        //
        // ex)
        // playerHealth?.Die();
        // ==
        // if (playerHealth != null)
        //{
        //    playerHealth.Die();
        //}
    }
    */
}
