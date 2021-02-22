using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float ViewSensitivity;

    public Transform Player;

    public float cameraXrotation;

    public Vector2 mouseInputs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player.Rotate(Vector3.up * mouseX);

        //cameraXrotation -= mouseY;
        transform.localRotation = Quaternion.Euler(cameraXrotation, 0f, 0f);
    }

    public Vector2 GetMouseInputs()
    {
        float mouseX = Input.GetAxis("Mouse X") * ViewSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * ViewSensitivity * Time.deltaTime;

        mouseInputs.x = mouseX;
        mouseInputs.y = mouseY;

        return mouseInputs;
    }


}
