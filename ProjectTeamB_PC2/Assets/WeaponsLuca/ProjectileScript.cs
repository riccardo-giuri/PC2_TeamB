using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileScript : MonoBehaviour
{
    private void Update()
    {
        
        Destroy(gameObject, 3f);

    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Enemy"))
       {
            Destroy(gameObject);
       }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}






