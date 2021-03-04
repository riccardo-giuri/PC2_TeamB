using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleePercentuale : MonoBehaviour
{
    
    private PlayerLifeWIP playerLifeScript;
    public float percentuale;
    private float percentualeDaSottrarre;
    private Animator anim;
    public string animazione = "Melee";
    private PlayerController playerController;


    public void Start()
    {
        anim = GetComponent<Animator>();
        playerController = FindObjectOfType<PlayerController>();
        playerLifeScript = GameObject.Find("Player").GetComponent<PlayerLifeWIP>();
    }
    public void Update()
    {
        
        percentualeDaSottrarre = playerLifeScript.lifeTimer * percentuale / 100f;

        if (Input.GetKeyDown(KeyCode.R))
        {
            playerController.Melee.gameObject.SetActive(true);
            anim.SetBool(animazione, true);
            playerLifeScript.lifeTimer = playerLifeScript.lifeTimer -  percentualeDaSottrarre;
        }
        else
        {
            playerController.Melee.gameObject.SetActive(false);
            anim.SetBool(animazione, false);
        }
    }


}
