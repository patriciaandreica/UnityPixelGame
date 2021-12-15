using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class rotates game objects
/// </summary>
public class Rotate : MonoBehaviour
{
    [SerializeField] protected float objectSpeed = 1f;
     void Update()
    {
        RotateObject();
    }

    /// <summary>
    /// Rotate the object on the z-axis
    /// </summary>
    private void RotateObject()
    {
        transform.Rotate(0, 0, 360 * objectSpeed * Time.deltaTime); 
    }
}
