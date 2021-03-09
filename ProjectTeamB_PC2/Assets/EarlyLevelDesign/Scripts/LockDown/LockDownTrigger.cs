using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDownTrigger : MonoBehaviour
{
    public GameObject borderIn, borderOut, lockDown;

    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (player.transform.position.z > borderIn.transform.position.z && player.transform.position.z < borderOut.transform.position.z)
        {
            lockDown.SetActive(true);
        }
    }
}
