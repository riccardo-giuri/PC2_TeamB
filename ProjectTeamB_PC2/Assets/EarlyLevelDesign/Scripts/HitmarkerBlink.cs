using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitmarkerBlink : MonoBehaviour
{
    public GameObject hitmarker;

    public void Blink()
    {
        hitmarker.SetActive(true);
    }
}
