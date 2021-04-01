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

public class PotionController : MonoBehaviour
{
    public enum PotionType
    {
        Speed,
        Jump
    }

    public PotionType potionType;
    public int potionModAmount = 0;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            if (potionType == PotionType.Jump)
            {
                collision.gameObject.GetComponent<PlayerMovement>().hasJumpPotion = true;
            }
            else if (potionType == PotionType.Speed)
            {
                collision.gameObject.GetComponent<PlayerMovement>().hasSpeedPotion = true;
            }

            collision.gameObject.GetComponent<PlayerMovement>().potionModAmount = potionModAmount;

            Destroy(this.gameObject);
        }
    }
}
