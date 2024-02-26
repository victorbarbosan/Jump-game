



using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("finish");
        }
    }
}
