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

public class GemstonePickUp : MonoBehaviour
{
    public AudioClip pickupClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Player")
        {
            AudioSource.PlayClipAtPoint(pickupClip, transform.position);
            Destroy(this.gameObject);
        }
    }
}
