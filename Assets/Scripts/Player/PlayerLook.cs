using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public float mouseSens = 13f;
    float xRotation = 0f;


    public Transform playerBody;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    

    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -45, 16);

        transform.localRotation = Quaternion.Euler(xRotation, -0, 0);

        playerBody.Rotate(Vector3.up * mouseX);

    }
}
