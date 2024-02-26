/*
* Filename:    FinishPoint.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 21, 2024
* Description: This script is used to load the next scene when the player collides with the finish point.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class FinishPoint : MonoBehaviour
{
    // Function:      OnTriggerEnter
    // Description:   If the player collides with the finish point, load the next scene
    // Parameter:     Collider other
    // Returns:       void
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
