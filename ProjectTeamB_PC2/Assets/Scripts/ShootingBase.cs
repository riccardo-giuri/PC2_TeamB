using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBase : MonoBehaviour
{
    public GameObject Ammo;
    public Transform AmmoStart;
    public float[] Delay;
    public float AmmoSpeed;

    private void Start()
    {
        
    }

    public void Shooting()
    {
        GameObject NewShot=Instantiate(Ammo, AmmoStart.position, transform.rotation);
        //NewShot.GetComponent<Rigidbody>().AddForce(Vector3.forward * AmmoSpeed, ForceMode.Impulse);
    }
}
