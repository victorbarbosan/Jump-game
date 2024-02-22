using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBody"))
        {
            Die();
        }
    }



    private void Die()
    {
        MeshRenderer playerMeshRenderer = GetComponent<MeshRenderer>();
        Rigidbody playerRigidBody = GetComponent<Rigidbody>();
        PlayerMovement playerMovement = GetComponent<PlayerMovement>();


        playerMeshRenderer.enabled = false;
        playerRigidBody.isKinematic = true;
        playerMovement.enabled = false;


    }
}
