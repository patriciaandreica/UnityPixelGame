using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player") // Platform collides with player
        {
            collision.gameObject.transform.SetParent(transform); // Sets player as a child of platform (meaning it will move with the platform since its now the parent)
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);  // When player leaves platform (no value); removed as a child
        }
    }
}
