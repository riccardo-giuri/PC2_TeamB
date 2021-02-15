using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodistruzione : MonoBehaviour
{
    public float life;
    public GameObject hitmarker;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ( life <= 0)
        {
            Transform EnemyPosition = gameObject.transform;
            WeaponDatabase weaponDatabase = FindObjectOfType<WeaponDatabase>();
            Instantiate(weaponDatabase.Weapons[Random.Range(0, 2)], EnemyPosition.position, EnemyPosition.rotation);
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            hitmarker.SetActive(true);
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 0.1f, gameObject.transform.localScale.y + 0.1f, gameObject.transform.localScale.z + 0.1f);
            life -= 1;
        }
    }
}
