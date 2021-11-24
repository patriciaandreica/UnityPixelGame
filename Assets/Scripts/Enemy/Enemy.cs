using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : PlayerHealth
{
    private int damageAmount;
    protected float enemySpeed = 1f;
    protected virtual void EnemyMovement() // Virtual method can be overriden
    {
        transform.Rotate(0, 360 * enemySpeed * Time.deltaTime, 0); // Rotate on y-axis
    }

    protected override void OnCollisionEnter2D(Collision2D collision) // Overriding so when player collides with enemy the player dies instantly
    {
        if (collision.gameObject.tag == "Player") 
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reload the scene (level)
        }
    }

    public virtual void Introduction()
    {
        Debug.Log("Enemy!");
    }

}
