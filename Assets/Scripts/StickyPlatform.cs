/*
* Filename:    StickyPlatform.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 19, 2024
* Description: This script is used to make the player stick to the platform when the player collides with the platform.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class StickyPlatform : MonoBehaviour
{

    // Function:      OnCollisionEnter
    // Description:   If the player collides with the platform, set the player as the parent of the platform
    // parameter:     Collision collision
    // Returns:       void
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }



    // Function:      OnCollisionExit
    // Description:   If the player exits the platform, set parent to null
    // parameter:     Collision collision
    // Returns:       void
    private void OnCollisionExit(Collision collision)
    {
        // If the colliding object is Player, set object as the parent
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
        