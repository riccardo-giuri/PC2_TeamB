using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinceOfPersia : MonoBehaviour
{
    public float timer, wave1Time, wave2Time, wave3Time;
    public GameObject wave1, wave2, wave3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < wave1Time)
        {
            wave1.SetActive(true);
        }
        if (timer < wave2Time)
        {
            wave2.SetActive(true);
        }
        if (timer < wave3Time)
        {
            wave3.SetActive(true);
        }
    }
}
