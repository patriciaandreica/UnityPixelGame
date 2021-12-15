using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The purpose of this class is to use waypoints. The purpose of waypoints
/// is to allow your object to move from one point to another and repeat. You can have multiple waypoints
/// but I only used two throughout the game, so that an object can move back and forth.
/// </summary>

public class WaypointFollower : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints; // creating an array to have multiple waypoints if wanted
    private int currentWaypointIndex = 0; // first index

    [SerializeField] private float platformSpeed = 2f; // speed of platform

  void Update()
{
        Flip();
}

 /// <summary>
 /// The purpose of this method is so that the object will walk to one point 
 /// and once reached, it will flip and keep repeating by resetting the index to zero. 
 /// </summary>
private void Flip()
{
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < 0.1f) // calculate distance between vectors (waypoint) and if close to 0
        {
            currentWaypointIndex++; // switch to next waypoint (object goes other way)
            if (currentWaypointIndex >= waypoints.Length) // if at last waypoint
            {
                currentWaypointIndex = 0; // reset again to 0 so it repeats
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * platformSpeed); // move platform every frame
    }
}

