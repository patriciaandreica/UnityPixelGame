using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// This class is responsible for the player's health
/// </summary>

public class PlayerHealth : MonoBehaviour
{

    protected int currentHealth;
    protected int maxHealth = 100;

    [SerializeField] protected Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Start the game off with maximum health
    }
    /// <summary>
    /// Method that reduces player health if it collides with trap; if 
    /// health is 0 or below, then the scene is reloaded
    /// </summary>
    /// <param name="collision"></param>
   protected virtual void OnCollisionEnter2D(Collision2D collision) // Get information on what object collides with
    {
        if (collision.gameObject.tag == "Trap") // If object collides with object tagged "Trap" 
        {
            // LO3 
            Enemy enemyOne = new MaskEnemy(); // Up-casting
            enemyOne.Introduction();
            currentHealth -= 25; // Reduce health
            healthText.text = "Health: " + currentHealth + "%";
            if ( currentHealth <= 0) // If player health is less than or equal to 0
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Then reload the scene (level)
            }
        }
    }

    /// <summary>
    /// This method adds points to player health if it collides with a cherry and
    /// also updates the health percentage UI text accordingly
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Cherry") // If object collides with object of tag "Cherry"
        {
            Destroy(collision.gameObject); // Then remove object with tag from screen
            if (currentHealth <= 75)
            {
                currentHealth += 25; // Increment once object collides with cherry
                healthText.text = "Health: " + currentHealth + "%";
            }

        }
    }
}
