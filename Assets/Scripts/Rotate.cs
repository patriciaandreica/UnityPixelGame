using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This class rotates game objects
public class Rotate : MonoBehaviour
{
    [SerializeField] protected float speed = 1f;
     void Update()
    {
        transform.Rotate(0, 0, 360 * speed * Time.deltaTime); // rotate on the z-axis
    }
}
