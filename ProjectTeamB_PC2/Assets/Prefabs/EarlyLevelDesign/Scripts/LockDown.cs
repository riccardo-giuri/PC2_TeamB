using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDown : MonoBehaviour
{
    public float lockDownTime;
    public GameObject enemyWave, doorOut, doorIn;

    // Start is called before the first frame update
    void Start()
    {
        doorIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        lockDownTime -= Time.deltaTime;

        if (lockDownTime <= 0)
        {
            doorOut.SetActive(true);
            enemyWave.SetActive(true);
        }

        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 0)
        {
            Debug.Log("Alright");
            doorOut.SetActive(false);
        }
    }
}
