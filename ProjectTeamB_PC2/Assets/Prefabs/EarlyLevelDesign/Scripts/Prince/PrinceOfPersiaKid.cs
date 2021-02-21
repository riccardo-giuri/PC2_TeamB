using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinceOfPersiaKid : MonoBehaviour
{
    public float time1, time2, time3;
    public GameObject wave1, wave2, wave3;

    private PrinceOfPersia persiaPrince;

    private void Start()
    {
        persiaPrince = GameObject.Find("PrinceOfPersiaTimer").GetComponent<PrinceOfPersia>();
    }

    private void Update()
    {
        if(persiaPrince.timer < time1)
        {
            Spawn1();
        }
        if (persiaPrince.timer < time2)
        {
            Spawn2();
        }
        if (persiaPrince.timer < time3)
        {
            Spawn3();
        }
    }

    public void Spawn1()
    {
        wave1.SetActive(true);
    }

    public void Spawn2()
    {
        wave2.SetActive(true);
        Debug.Log("Merdone");
    }

    public void Spawn3()
    {
        wave3.SetActive(true);
    }
}
