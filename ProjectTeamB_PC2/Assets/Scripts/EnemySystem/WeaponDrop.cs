using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDrop : MonoBehaviour
{
    //public Rigidbody RB;
    public WeaponDatabase weaponDatabase;
    public LayerMask WeaponDropLayer;

    public void Start()
    {
        weaponDatabase = FindObjectOfType<WeaponDatabase>();
    }

    public void DropWeapon()
    {
        Instantiate(RandomWeaponDrop(), transform.position, Quaternion.identity);
    }

    public Vector3 CalculateWeaponPosition()
    {
        Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 50f, WeaponDropLayer);

        Vector3 WeaponSpawnPoint = hit.point + new Vector3(0f, 2f, 0f);

        return WeaponSpawnPoint;
    } 

    public GameObject RandomWeaponDrop()
    {
        int RandomIndex = Random.Range(0, weaponDatabase.Weapons.Length);
        return weaponDatabase.Weapons[RandomIndex];
    }
}
