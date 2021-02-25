using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WeaponData", menuName = "Create WeaponData")]
public class WeaponData : ScriptableObject
{
    /// <summary>
    /// Charge value of a weapon
    /// </summary>
    public float Charge;    
    /// <summary>
    /// Damage value of a single projectile
    /// </summary>
    public float Damage;
    /// <summary>
    /// First Projectile Damage 
    /// </summary>
    public float FirstProjectileDamage;
    /// <summary>
    /// Percentage slow of the weapon
    /// </summary>
    public float Weight;
    /// <summary>
    /// The Distance where the damage reduction is active
    /// </summary>
    public float Range;
    /// <summary>
    /// Percentage damage reduction after the range distance
    /// </summary>
    public float RangeDmgReduction;    
    /// <summary>
    /// Amount of force that knockback the player when he shoot with this weapon
    /// </summary>
    public float RecoilKnockBack;
    /// <summary>
    /// Amount of force the weapon give to the projectile shooted
    /// </summary>
    public float ShootingForce;

    //sarà la lista dei tipi di shooting che la nostra arma avrà
    
}
