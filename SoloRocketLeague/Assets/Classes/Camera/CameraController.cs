using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float MouseSensitivity = 200f;
    public float CameraMoveSpeed = 100f;
    public GameObject TheCamera;
    public GameObject ToFollow;
    private float rotX;
    private float rotY;
    private float maxAngle = 80f;
    // Start is called before the first frame update
    void Start()
    {
        rotX = 0f;
        rotY = 0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float yMovement = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;
        rotX += xMovement;
        rotY -= yMovement;
        transform.rotation = Quaternion.Euler(Mathf.Clamp(rotY, -maxAngle, maxAngle), rotX, 0f);
    }

    void LateUpdate()
    {
        float step = CameraMoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, ToFollow.transform.position, step);
    }

}
