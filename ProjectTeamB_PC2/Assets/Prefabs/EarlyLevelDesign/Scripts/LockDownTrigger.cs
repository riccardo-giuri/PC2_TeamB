using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDownTrigger : MonoBehaviour
{
    public GameObject lockDown;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lockDown.SetActive(true);
        }
    }

}
