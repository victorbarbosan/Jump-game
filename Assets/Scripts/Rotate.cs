/*
* Filename:    Rotate.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 21, 2024
* Description: This script is used to rotate the object.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Rotate : MonoBehaviour
{
    // Variables
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;
    float rotationAngle = 360;
    
 

    // Update
    void Update()
    {
        transform.Rotate(rotationAngle * speedX * Time.deltaTime, rotationAngle * speedY * Time.deltaTime, rotationAngle * speedZ * Time.deltaTime);
    }
}
