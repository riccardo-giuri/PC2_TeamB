using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    /// <summary>
    /// Current weapont datas
    /// </summary>
    public WeaponData weaponData;

    //va calcolata poi in modo differente nelle classi shooting type
    /// <summary>
    /// Total Damage done by a weapon
    /// </summary>
    public float TotalDamage;

    //variabili che vanno inserite post shooting system
    //current weapon shooting type
    //starting shooting type
    

    /// <summary>
    /// Calculate the hit Damage of the weapon after a Range
    /// </summary>
    /// <param name="HitDistance"></param>
    /// <param name="Damage"></param>
    /// <param name="RangeDistance"></param>
    /// <param name="percentageDmgReduction"></param>
    /// <returns></returns>
    public float CalculateRangeDamageDrop(float HitDistance, float Damage, float RangeDistance, float percentageDmgReduction)
    {
        if(HitDistance > RangeDistance)
        {
            float DmgReductionValue = ((Damage / 100) * percentageDmgReduction);
            float DamageReduced = Damage - DmgReductionValue;
            return DamageReduced;
        }
        else
        {
            return Damage;
        }
    }

    /// <summary>
    /// Calculate The Speed Reduced by the Weapon Weight
    /// </summary>
    /// <param name="Speed"></param>
    /// <param name="Weight"></param>
    /// <returns></returns>
    public float ApplyWeaponWeightReduction(float Speed, float Weight)
    {
        float SpeedReductionValue = ((Speed / 100) * Weight);
        float SpeedReduced = Speed - SpeedReductionValue;
        return SpeedReduced;
    }

    /// <summary>
    /// Apply Knockback to a player after he shoot
    /// </summary>
    /// <param name="currentMovingDirection"></param>
    /// <param name="playerRB"></param>
    /// <param name="knockBack"></param>
    public void ApplyWeaponKnockBack(Vector3 playerDirection, Rigidbody playerRB, float knockBack)
    {
        Vector3 reverseDirection = playerDirection * -1;
        playerRB.AddForce(reverseDirection, ForceMode.Impulse);
    }

    //metodo che switcha tra le varie forme di shooting
    //Change shooting type
}
