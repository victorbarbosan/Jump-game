/*
* Filename:    WaypointFollower.cs
* Project:     Jump game
* By:          Victor Barbosa
* Date:        February 19, 2024
* Description: This script is used to make the object follow waypoints.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WaypointFollower : MonoBehaviour
{
    //Variables
    [SerializeField] GameObject[] waypoints;
    [SerializeField] float speed = 1f;
    int currentWaypointIndex = 0;



    // Update
    void Update()
    {
        // Check if object position is the same as waypoint and increase index
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length) // reset index if end of array
            {
                currentWaypointIndex = 0;
            }
        }

        // Move towards the waypoint position
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
