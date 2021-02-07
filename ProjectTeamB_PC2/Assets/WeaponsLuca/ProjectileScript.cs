using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileScript : MonoBehaviour
{
    
    private void Update()
    {
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Transform EnemyPosition = other.gameObject.transform;
            Destroy(other.gameObject);
            WeaponDatabase weaponDatabase = FindObjectOfType<WeaponDatabase>();
            Instantiate(weaponDatabase.Weapons[Random.Range(0, 2)], EnemyPosition.position, EnemyPosition.rotation);
        }
    }

}






