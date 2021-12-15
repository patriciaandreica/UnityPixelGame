using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is so that once an collides with a moving platform, it can sit on it
/// and move along with the platform rather than fall off
/// </summary>

public class StickyPlatform : MonoBehaviour
{

    /// <summary>
    /// Once the player collides with platform, set the player as a child of the platform,
    /// which is how it will allow the player to move with the platform
    /// </summary>
    /// <param name="collision"> The platform</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player") // Platform collides with player
        {
            collision.gameObject.transform.SetParent(transform); // Sets player as a child of platform (meaning it will move with the platform since its now the parent)
        }
    }
    /// <summary>
    /// Same as method above but now it will remove the player as a child by setting it to null
    /// </summary>
    /// <param name="collision"> The platform</param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);  // When player leaves platform (no value); removed as a child
        }
    }
}
