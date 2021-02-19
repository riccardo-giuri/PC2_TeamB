using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShoot : ShootingBase
{
    public bool CanShoot;
    public float Charge;
    public float BuckshotAngle;
    public int NBuckshot;
    PauseMenu PM;
    PlayerLife PL;
    List<Quaternion> Bullets;

    public enum ShootType
    {
        Auto,
        Single,
        ThreeHits,
        Buckshot
    }
    public ShootType Shoot_Type;

    private void Awake()
    {
        if(Shoot_Type==ShootType.Buckshot)
        {
            Bullets = new List<Quaternion>(NBuckshot);
            for(int i=0; i<NBuckshot; i++)
            {
                Bullets.Add(Quaternion.Euler(Vector3.zero));
            }
        }
    }

    void Start()
    {
        PM = FindObjectOfType<PauseMenu>();
        PL = FindObjectOfType<PlayerLife>();
        PL.BulletTimer = Charge;
    }

    // Update is called once per frame
    void Update()
    {
        if(PM.IsStopped==false&&PL.BulletTimer>0)
        {
            ShootingType();
        }
    }



    public void ShootingType()
    {
        switch(Shoot_Type)
        {
            case ShootType.Auto:
                Auto();
                break;
            case ShootType.Single:
                Single();
                break;
            case ShootType.ThreeHits:
                ThreeHits();
                break;
            case ShootType.Buckshot:
                BuckShot();
                break;
        }
    }
    public void Auto()
    {
        if(Input.GetMouseButton(0))
        {
            StartCoroutine(ShootWait());
        }
    }
    public void Single()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShootWait());
        }
    }
    public void ThreeHits()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShootWait());
        }
    }
    public void BuckShot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShootWait());
        }
    }

    public void Buckshot()
    {
        for(int B=0; B<NBuckshot; B++)
        {
            Bullets[B] = Random.rotation;
            GameObject b = Instantiate(Ammo, AmmoStart.position, transform.rotation);
            b.transform.rotation = Quaternion.RotateTowards(b.transform.rotation, Bullets[B], BuckshotAngle);
            b.GetComponent<Rigidbody>().AddForce(Vector3.forward * AmmoSpeed);
            B++;
        }
    }

    IEnumerator ShootWait()
    {
        yield return new WaitForSeconds(Delay[0]);
        if(Shoot_Type==ShootType.Auto)
        {
            Shooting();
        }
        else if(Shoot_Type==ShootType.Single)
        {
            Shooting();
            CanShoot = false;
            yield return new WaitForSeconds(Delay[1]);
            CanShoot = true;
        }
        else if(Shoot_Type==ShootType.ThreeHits)
        {
            for (int i= 0; i<3; i++)
            {
                Shooting();
                yield return new WaitForSeconds(Delay[1]);
            }
            CanShoot = false;
            yield return new WaitForSeconds(Delay[2]);
            CanShoot = true;
        }
        else if(Shoot_Type==ShootType.Buckshot)
        {
            Buckshot();
            CanShoot = false;
            yield return new WaitForSeconds(Delay[1]);
            CanShoot = true;
        }
    }
}
