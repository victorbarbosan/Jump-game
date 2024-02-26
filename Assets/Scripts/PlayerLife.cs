/*
* Filename:    PlayerMovement.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 21, 2024
* Description: This script is used to control the player's movement and jump.
*/



using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerLife : MonoBehaviour
{
    // Variables
    [SerializeField] AudioSource dieSound;
    bool dead = false;
    float waitTime = 1.3f;
    float deathHeight = -4f;
    


    // Update
    private void Update()
    {
        // Die if fall
        if (transform.position.y < deathHeight && !dead)
        {            
            Die();
        }
    }



    // Function:      OnCollisionEnter
    // Description:   If the player collides with the enemy, call Die function
    // Parameter:     Collision collision
    // Returns:       void
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBody"))
        {
            Die();
        }
    }


    
    // Function:      Die
    // Description:   Disable Player controls, wait a moment and reload level
    // Parameter:     None
    // Returns:       void
    private void Die()
    {
        // Play sound
        dieSound.Play();

        // Disable Player controls
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<PlayerMovement>().enabled = false;
        dead = true;
        
        // Wait a moment and reload level
        Invoke(nameof(ReloadLevel), waitTime);
    }



    // Function:      ReloadLevel
    // Description:   Reload the current level
    // Parameter:     None
    // Returns:       void
    private void ReloadLevel()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
