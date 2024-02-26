/*
* Filename:    EndMenu.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 21, 2024
* Description: This script is used to control the end menu.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EndMenu : MonoBehaviour
{
    // Function:      QuitGame
    // Description:   Quit the game
    // Parameter:     None
    // Returns:       void
    public void QuitGame()
    {
        Application.Quit();
    }
}
