/*
* Filename:    PlayerMovement.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 17, 2024
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
    [SerializeField] AudioSource jumpSound;
    Rigidbody rb;
    float horizontalInput;
    float verticalInput;


    // Start
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update
    void Update()
    {
        // Movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        rb.velocity = new Vector3(horizontalInput * moveSpeed, rb.velocity.y, verticalInput * moveSpeed);

        // Jump
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }
    }



    // Function:      Jump
    // Description:   Make the player jump
    // Parameter:     None
    // Returns:       void
    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        jumpSound.Play();
    }



    // Function:      IsGrounded
    // Description:   Check if the player is grounded
    // Parameter:     None
    // Returns:       bool
    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);        
    }



    // Function:      OnCollisionEnter
    // Description:   If the player collides with the enemy head, destroy the enemy and make the player jump
    // Parameter:     Collision collision
    // Returns:       void
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyHead"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }
}
