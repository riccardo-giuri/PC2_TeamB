using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public GameObject puntiDispawn1;
    public GameObject puntiDispawn2;

    private void OnTriggerStay(Collider other)
    {
        puntiDispawn1.SetActive(true);
        puntiDispawn2.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        puntiDispawn1.SetActive(false);
        puntiDispawn2.SetActive(false);
    }
}

   
