/*
Name: Katie Tang
Student ID#: 2313452
Chapman email: htang@chapman.edu
Course Number and Section: 236-03
Assignment: Project05 Platformer
This is my own work, and I did not cheat on this assignment.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTransform;
    private Vector3 smoothPos;
    private float smoothSpeed = 0.5f;

    public GameObject cameraLeftBorder;
    public GameObject cameraRightBorder;

    private float cameraHalfWidth;
    // Start is called before the first frame update
    void Start()
    {
        cameraHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float borderLeft = cameraLeftBorder.transform.position.x + cameraHalfWidth;
        float borderRight = cameraRightBorder.transform.position.x - cameraHalfWidth;

        smoothPos = Vector3.Lerp(this.transform.position,
            new Vector3(Mathf.Clamp(followTransform.position.x, borderLeft, borderRight),
            this.transform.position.y,
            this.transform.position.z), smoothSpeed);

        this.transform.position = smoothPos;
    }
}
