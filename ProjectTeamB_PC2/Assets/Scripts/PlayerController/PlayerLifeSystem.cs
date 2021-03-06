﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeSystem : MonoBehaviour
{
    /// <summary>
    /// Player current Hp
    /// </summary>
    public float PlayerCurrentHP;
    /// <summary>
    /// Hp value at the start of the game
    /// </summary>
    public float PlayerStartingHP;
    /// <summary>
    /// time gain for killing an enemy
    /// </summary>
    public float EnemyTimeGain;


    //variabili UI da eliminare in futuro
    public Text LifeText;
    public GameObject DeathPanel;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCurrentHP = PlayerStartingHP;
    }

    /// <summary>
    /// Countdown of the player Life 
    /// </summary>
    public void LifeTimer()
    {
        if (PlayerCurrentHP > 0)
        {
            LifeText.text = PlayerCurrentHP.ToString("F0");
            PlayerCurrentHP -= Time.deltaTime;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            DeathPanel.SetActive(true);
        }
    }

    public void DamagePlayer(float Amount)
    {
        PlayerCurrentHP -= Amount;
    }
}
