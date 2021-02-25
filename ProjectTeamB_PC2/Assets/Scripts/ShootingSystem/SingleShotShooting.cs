using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotShooting : Shooting
{
    public override void ShootingAction(RangedWeapon currentWeapon)
    {
        if(CanWeaponShoot == true)
        {
            Shoot(currentWeapon);
            StartCoroutine(ActivateShotCooldown(ShotCooldown));
        }       
    }

    public override void Shoot(RangedWeapon currentWeapon)
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

        Vector3 ShootingDirection = ShootingTargetPoint - currentWeapon.GunBarrel.position;

        GameObject BulletInstance = Instantiate(currentWeapon.WeaponBulletPrefab , currentWeapon.GunBarrel.position, Quaternion.identity);

        BulletInstance.transform.forward = ShootingDirection.normalized;

        BulletInstance.GetComponent<Rigidbody>().AddForce(ShootingDirection.normalized * currentWeapon.weaponData.ShootingForce, ForceMode.Impulse);
    }
}
