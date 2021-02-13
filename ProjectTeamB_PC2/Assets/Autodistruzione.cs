using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodistruzione : MonoBehaviour
{
    public float LaGuerraaaaaPiuTotaleee;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, LaGuerraaaaaPiuTotaleee);
    }
}
