using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void Die()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Die();
        }

        /*
         if (null == other.GetComponent<Bullet()>)
        {
            // other¿∫ Bullet¿Ã æ∆¥‘.
        }
        */
    }
}
