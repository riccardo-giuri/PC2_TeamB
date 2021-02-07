using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FirstFloor") == false && other.CompareTag("Player") == false)
        {
            if (other.CompareTag("SpawnPoint"))
            {
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(other.gameObject.transform.parent.gameObject);
            }
        }       
    }
}
