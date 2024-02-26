/*
* Filename:    StartMenu.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 21, 2024
* Description: This script is used to control the start menu.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class StartMenu : MonoBehaviour
{
    // Function:      StartGame
    // Description:   Load the next scene
    // Parameter:     None
    // Returns:       void
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
