using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints; // creating an array to have multiple waypoints if wanted
    private int currentWaypointIndex = 0; // first index

    [SerializeField] private float speed = 2f; // speed of platform
  void Update()
    {
      if(Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < 0.1f) // calculate distance between vectors (waypoint) and if close to 0
        {
            currentWaypointIndex++; // switch to next waypoint (object goes other way)
            if(currentWaypointIndex >= waypoints.Length) // if at last waypoint
            {
                currentWaypointIndex = 0; // reset again to 0 so it repeats
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed); // move platform every frame
    }
}

