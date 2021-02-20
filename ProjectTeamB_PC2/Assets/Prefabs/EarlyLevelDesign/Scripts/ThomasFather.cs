using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThomasFather : MonoBehaviour
{
    public GameObject room1;

    private float spawnRoomLengh;
    private Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
        spawnRoomLengh = GetComponent<BoxCollider>().size.z;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("SpawnPos" + spawnPos);

        if (transform.position.z >= spawnPos.z + spawnRoomLengh)
        {
            spawnPos = transform.position;
            Instantiate(room1, gameObject.transform.position, gameObject.transform.rotation);
        }
    }

    private void OnTriggerExit(Collider other)
    {
       //if (other.CompareTag("Room"))
       //{
       //    Debug.Log("EccoloIlBastardo");
       //    Instantiate(room1, gameObject.transform.position, gameObject.transform.rotation);
       //}
    }
}
