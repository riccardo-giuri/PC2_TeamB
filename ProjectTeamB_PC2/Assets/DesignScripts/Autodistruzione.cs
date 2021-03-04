using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodistruzione : MonoBehaviour
{
    public float life;
    public PlayerLife myScript;
    public float LifeBonus;

    private HitmarkerBlink blink;

    void Start()
    {
        myScript = GameObject.Find("Player").GetComponent<PlayerLife>();
        blink = GameObject.Find("HitmarkerFather").GetComponent<HitmarkerBlink>();
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

            if (myScript.lifeTimer < myScript.MaxPlayerLife) 
            {  
                myScript.lifeTimer = myScript.lifeTimer + LifeBonus;
            }
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            blink.Blink();
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 0.1f, gameObject.transform.localScale.y + 0.1f, gameObject.transform.localScale.z + 0.1f);
            life -= 1;
        }
        if (other.CompareTag("Melee"))
        {
            blink.Blink();
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + 0.1f, gameObject.transform.localScale.y + 0.1f, gameObject.transform.localScale.z + 0.1f);
            life -= life;
        }
    }
}
