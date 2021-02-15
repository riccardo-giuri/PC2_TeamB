using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPickup : MonoBehaviour
{
    public GameObject WeaponToSpawn;
    private PlayerController playerController;
    public Text UipickupText;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            playerController.UIPickup.gameObject.SetActive(true);
        }        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.transform.parent.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E)|| Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
             
            SwitchWeapon();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            playerController.UIPickup.gameObject.SetActive(false);
        }
    }

    void SwitchWeapon()
    {
        Destroy(playerController.CurrentWeapon);
        GameObject CurrentNewWeapon = Instantiate(WeaponToSpawn, playerController.WeaponPointToSpawn);
        playerController.CurrentWeapon = CurrentNewWeapon;
        playerController.UIPickup.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
