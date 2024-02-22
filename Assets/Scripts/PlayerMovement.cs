/*
* Filename:    PlayerMovement.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 21, 2024
* Description: This script is used to control the player's movement and jump.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    // Variables
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpSpeed = 8f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    Rigidbody rb;
    float horizontalInput;
    float verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        // Movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        rb.velocity = new Vector3(horizontalInput * moveSpeed, rb.velocity.y, verticalInput * moveSpeed);

        // Jump
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        }
    }


    // Function:      IsGrounded
    // Description:   Check if the player is grounded
    // parameter:     None
    // Returns:       bool
    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
}
