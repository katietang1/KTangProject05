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

public class FloatingMovement : MonoBehaviour
{
    private float floatingTimer = 0f;
    public float floatingMax = 1f;
    public float floatingDir = 0.01f;

    private void FixedUpdate()
    {
        if (floatingTimer < floatingMax)
        {
            transform.position = new Vector2(transform.position.x,
                transform.position.y + (Time.fixedDeltaTime * floatingDir));
            floatingTimer += Time.fixedDeltaTime;
        }
        else
        {
            floatingDir *= -1;
            floatingTimer = 0f;
        }
    }
}
