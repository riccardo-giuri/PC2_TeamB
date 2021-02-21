using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesTrigger : MonoBehaviour
{
    public GameObject borderIn, borderOut, enemies;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z > borderIn.transform.position.z && player.transform.position.z < borderOut.transform.position.z)
        {
            enemies.SetActive(true);
        }
        else if (player.transform.position.z < borderIn.transform.position.z || player.transform.position.z > borderOut.transform.position.z)
        {
            enemies.SetActive(false);
        }
    }
}
