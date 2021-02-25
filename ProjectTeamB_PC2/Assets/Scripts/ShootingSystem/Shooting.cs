using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Shooting : MonoBehaviour
{
    public float ShotCooldown;
    public bool CanWeaponShoot = true;
    public bool IsAutomatic;
    protected Vector3 ShootingTargetPoint;

    public virtual void Shoot(RangedWeapon currentWeapon) { }

    public virtual void ShootingAction(RangedWeapon currentWeapon) { }

    public virtual float CalculateFireRateo(RangedWeapon CurrentWeapon)
    {
        return CurrentWeapon.FireRateo;
    }

    public virtual float CalculateTotalDamage(RangedWeapon CurrentWeapon)
    {
        return CurrentWeapon.weaponData.Damage;
    }

    public void SetupCanWeaponShoot(bool canWeaponShoot)
    {
        if(canWeaponShoot == true)
            return;
        else
            canWeaponShoot = !canWeaponShoot;
    }

    public IEnumerator ActivateShotCooldown(float shotCooldown)
    {
        CanWeaponShoot = false;

        yield return new WaitForSeconds(shotCooldown);

        CanWeaponShoot = true;
    }
}
