using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstShootingType : Shooting
{
    /// <summary>
    /// Number of shots in single burst
    /// </summary>
    public int SingleBurstShots;
    /// <summary>
    /// Cooldown timer between bursts fire
    /// </summary>
    public float CooldownBetweenBursts;

    public override void ShootingAction(RangedWeapon currentWeapon)
    {
        if(CanWeaponShoot == true)
        {
            StartCoroutine(ShootBurst(ShotCooldown, currentWeapon));
            StartCoroutine(ActivateShotCooldown(CooldownBetweenBursts));
        }       
    }

    public override void Shoot(RangedWeapon currentWeapon)
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            ShootingTargetPoint = hit.point;
        }
        else
        {
            ShootingTargetPoint = ray.GetPoint(80);
        }

        Vector3 ShootingDirection = ShootingTargetPoint - currentWeapon.GunBarrel.position;

        GameObject BulletInstance = Instantiate(currentWeapon.WeaponBulletPrefab, currentWeapon.GunBarrel.position, Quaternion.identity);

        BulletInstance.transform.forward = ShootingDirection.normalized;

        BulletInstance.GetComponent<Rigidbody>().AddForce(ShootingDirection.normalized * currentWeapon.weaponData.ShootingForce, ForceMode.Impulse);
    }

    public IEnumerator ShootBurst(float shotCooldown, RangedWeapon currentWeapon)
    {
        if (SingleBurstShots >= 2)
        {
            for (int shots = 0; shots < SingleBurstShots; shots++)
            {
                Shoot(currentWeapon);
                yield return new WaitForSeconds(shotCooldown);
            }
        }

    }
}
