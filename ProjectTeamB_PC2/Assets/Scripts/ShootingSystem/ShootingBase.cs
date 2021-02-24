using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Shooting : MonoBehaviour
{
    public float ShotCooldown;
    public bool CanShoot = true;
    protected Vector3 ShootingTargetPoint;


    public virtual void Shoot(RangedWeapon CurrentWeapon) { }

    public virtual float CalculateFireRateo(RangedWeapon CurrentWeapon)
    {
        return CurrentWeapon.FireRateo;
    }

    public virtual float CalculateTotalDamage(RangedWeapon CurrentWeapon)
    {
        return CurrentWeapon.weaponData.Damage;
    }
}
