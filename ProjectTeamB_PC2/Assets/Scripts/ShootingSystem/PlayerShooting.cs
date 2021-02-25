using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public RangedWeapon CurrentRagedWeapon;

    // Start is called before the first frame update
    void Start()
    {
        CurrentRagedWeapon.ShootingType.SetupCanWeaponShoot(CurrentRagedWeapon.ShootingType.CanWeaponShoot);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && CurrentRagedWeapon.ShootingType.IsAutomatic == false)
        {
            CurrentRagedWeapon.ShootingType.ShootingAction(CurrentRagedWeapon);
        }
        if (Input.GetMouseButton(0) && CurrentRagedWeapon.ShootingType.IsAutomatic == true)
        {
            CurrentRagedWeapon.ShootingType.ShootingAction(CurrentRagedWeapon);
        }
    }
}
