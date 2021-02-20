using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThomasFather : MonoBehaviour
{
    public GameObject room1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Room"))
        {
            Debug.Log("EccoloIlBastardo");
            Instantiate(room1, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
