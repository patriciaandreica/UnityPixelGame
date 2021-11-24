using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.name == "Player") // Player collides with flag
        {
            Invoke("LevelComplete", 2f); // Call method to go to next level
        }
    }

    private void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Index to next level
    }

}
