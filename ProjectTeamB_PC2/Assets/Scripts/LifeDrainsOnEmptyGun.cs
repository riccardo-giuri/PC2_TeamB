﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDrainsOnEmptyGun : MonoBehaviour 
{

    public float Proiettili;
    public float DrainSpeed;

    private PlayerLife Myscript;

    public GameObject bullet;


    public float shootForce, upwardForce;


    public float timeBetweenShooting, spread;
    public int bulletsPerTap;
    public bool allowButtonHold;



    //public Rigidbody playerRb;
    public float recoilForce;


    bool shooting, readyToShoot;


    private Camera fpsCam;
    public Transform attackPoint;


    public GameObject muzzleFlash;



    public bool allowInvoke = true;

    private void Awake() {
        readyToShoot = true;
    }

    private void Start() {
        //playerRb = GameObject.Find("Player").GetComponent<Rigidbody>();
        Myscript = GameObject.Find("Player").GetComponent<PlayerLife>();
        Myscript.BulletTimer = Proiettili;
        fpsCam = Camera.main;

    }

    private void Update() {
        MyInput();

    }
    private void MyInput() {
        //Check if allowed to hold down button and take corresponding input
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Joystick1Button7);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Joystick1Button7);

        //Shooting
        if (readyToShoot && shooting && Myscript.BulletTimer > 0) {
            Shoot();

        }

        if (readyToShoot && shooting && Myscript.BulletTimer <= 0) {
            Shoot();
            Myscript.lifeTimer -= Time.deltaTime * DrainSpeed;
        }
    }

    private void Shoot() {
        readyToShoot = false;

        Ray ray = fpsCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;


        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75);


        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;

        //spread se dovesse servire
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        //direzione spread
        Vector3 directionWithSpread = directionWithoutSpread + new Vector3(x, y, 0);

        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity);


        currentBullet.transform.forward = directionWithSpread.normalized;

        currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
        currentBullet.GetComponent<Rigidbody>().AddForce(fpsCam.transform.up * upwardForce, ForceMode.Impulse);

        if (muzzleFlash != null)
            Instantiate(muzzleFlash, attackPoint.position, Quaternion.identity);

        if (allowInvoke) {
            Invoke("ResetShot", timeBetweenShooting);
            allowInvoke = false;

            //rinculo dell'arma
            //playerRb.AddForce(-directionWithSpread.normalized * recoilForce, ForceMode.Impulse);
        }

    }
    private void ResetShot() {
        readyToShoot = true;
        allowInvoke = true;
    }




}

