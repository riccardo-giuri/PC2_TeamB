using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed = 10;
	public float gravity = 9.81f;
	public float JumpSpeed = 100;
	float VerticalSpeed = 0;
	CharacterController cController;

	//temporary variable
	public Transform WeaponPointToSpawn;
	public GameObject CurrentWeapon;
	public Text UIPickup;

	void Start()
	{
		cController = GetComponent<CharacterController>();
	}

	void Update()
	{
		float Horizontal = Input.GetAxis("Horizontal");
		float Forward = Input.GetAxis("Vertical");
		if (!cController.isGrounded) VerticalSpeed = VerticalSpeed - gravity * Time.deltaTime;
		else VerticalSpeed = -gravity;
	
		if (Input.GetKeyDown(KeyCode.Space) /*|| Input.GetKeyDown(KeyCode.Joystick1Button1)*/ && cController.isGrounded)
		{
			VerticalSpeed = JumpSpeed;
		}
		Vector3 ForwardSpeed = this.transform.forward * Forward * speed;
		Vector3 LateralSpeed = this.transform.right * Horizontal * speed;
		cController.Move((ForwardSpeed + Vector3.up * VerticalSpeed) * Time.deltaTime);
		cController.Move((LateralSpeed + Vector3.up * VerticalSpeed) * Time.deltaTime);
	}
}
