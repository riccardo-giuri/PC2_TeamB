using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public float lifeTimer, BulletTimer;

    

    // Start is called before the first frame update
    void Start()
    {
        
             
    }

    // Update is called once per frame
    void Update()
    {
        if(BulletTimer != 0)
        {
            BulletTimer -= Time.deltaTime;
        }

        if(BulletTimer <= 0)
        {
            lifeTimer -= Time.deltaTime;
        }

        Debug.Log("BulletTimer" + BulletTimer);
        Debug.Log("lifeTimer" + lifeTimer);
    }

   
}
