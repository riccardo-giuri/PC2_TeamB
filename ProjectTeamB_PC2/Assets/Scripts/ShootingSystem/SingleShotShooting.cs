using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotShooting : Shooting
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Shoot(RangedWeapon CurrentWeapon)
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            ShootingTargetPoint = hit.point;
        }
        else
        {
            ShootingTargetPoint = ray.GetPoint(80);
        }

        Vector3 ShootingDirection = ShootingTargetPoint - CurrentWeapon.GunBarrel.position;

        GameObject currentBullet = Instantiate(bulletPrefab, CurrentWeapon.GunBarrel.position, Quaternion.identity);
    }
}
