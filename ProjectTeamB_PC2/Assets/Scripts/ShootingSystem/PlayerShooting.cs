using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShooting : MonoBehaviour
{
    public RangedWeapon CurrentRagedWeapon;

    //temporary UI Variable
    public Text AmmoText;

    // Start is called before the first frame update
    void Start()
    {
        CurrentRagedWeapon.ShootingType.SetupCanWeaponShoot();
        CurrentRagedWeapon.SetupCurrentAmmo();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentRagedWeapon.UpdateFireRateoValue();
        CurrentRagedWeapon.UpdateTotalDamageValue();
        UpdateAmmoUI();

        //Execute shooting
        if (Input.GetMouseButtonDown(0) && CurrentRagedWeapon.ShootingType.IsAutomatic == false)
        {
            CurrentRagedWeapon.ShootingType.ShootingAction(CurrentRagedWeapon);
        }
        if (Input.GetMouseButton(0) && CurrentRagedWeapon.ShootingType.IsAutomatic == true)
        {
            CurrentRagedWeapon.ShootingType.ShootingAction(CurrentRagedWeapon);
        }
    }

    public void UpdateAmmoUI()
    {
        AmmoText.text = CurrentRagedWeapon.CurrentAmmo.ToString("F0");
    }
}
