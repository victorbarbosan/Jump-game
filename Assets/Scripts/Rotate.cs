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
    
 

    
    void Update()
    {
        transform.Rotate(rotationAngle * speedX * Time.deltaTime, rotationAngle * speedY * Time.deltaTime, rotationAngle * speedZ * Time.deltaTime);
    }
}
