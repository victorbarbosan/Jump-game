/*
* Filename:    ItemCollector.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 21, 2024
* Description: This script is used to control the player's movement and jump.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ItemCollector : MonoBehaviour
{
    // Variables
    int coinsCount = 0;
    [SerializeField] Text coinsCountText;
    [SerializeField] AudioSource coinSound;



    // Function:      OnTriggerEnter
    // Description:   If the player collides with the coin, destroy the coin and increase the coin count
    // Parameter:     Collider other
    // Returns:       void
    private void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinSound.Play();
            coinsCount++;
            coinsCountText.text = "Coins: " + coinsCount.ToString();
        }
    }
}
