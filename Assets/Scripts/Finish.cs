using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This class is responbsible for going to the next level once player collides with flag
/// </summary>
public class Finish : MonoBehaviour
{
    /// <summary>
    /// Once player collides with completion flag, then call LevelComplete function to 
    /// advance to the next level after 2 seconds of colliding with it
    /// </summary>
    /// <param name="collision">The object that is attached to it, so the collision in this
    /// case would be the completion flag</param>
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.name == "Player") // Player collides with flag
        {
            Invoke("LevelComplete", 2f); // Call LevelComplete method to go to next level 
        }
    }

    /// <summary>
    /// This method takes the current scene and indexes to the next one by adding 1
    /// </summary>
    private void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Index to next level
    }

}
