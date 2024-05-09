using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    float xRotation = 0f;
    float yRotation = 0f;
    public float topClamp = -90f;
    public float bottomClamp = 90f;

    void Start()
    {
        //locking the cursor to the middle and making it invisible
        Cursor.lockState = CursorLockMode.Locked;

        
    }

    
    void Update()
    {
       //getting the mouse inputs
       float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
       float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;


       // Rotation around the x axis (look up and down)
       xRotation -= mouseY;


       // clamp the rotation (maximize the rotation)
       xRotation = Mathf.Clamp(xRotation, topClamp, bottomClamp);


        // rotation around the y axis (look left and right)
        yRotation += mouseX;
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
