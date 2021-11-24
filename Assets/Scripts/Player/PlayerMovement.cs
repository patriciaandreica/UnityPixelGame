using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Procedural programming is written and executed in sequential order as instructions
// Functional programming is similar to procedural but everything is inside of functions that interact with each other directly
// In OOP, data and code are enclosed together and divided into classes in order to produce objects

public class PlayerMovement : MonoBehaviour  // All scripts extend from this base class 
{
    private Rigidbody2D playerBody;
    private BoxCollider2D playerCollided;

    [SerializeField] private LayerMask jumpableGround;
    private void Start() // Called when the game starts 
    {
        playerBody = gameObject.GetComponent<Rigidbody2D>(); // Targets the game object
        playerCollided = gameObject.GetComponent<BoxCollider2D>();

   
    }
    private void Update() // Called once per frame
    {
        PlayerWalk(); // Calling the methods for every frame
        PlayerJump();
       
    }
    private void PlayerJump() // Method for a player to jump
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded()) // If the up arrow key is pressed
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, 10f); // Then target the object to jump
           
        }
    }
    private void PlayerWalk()
    {
        float getInput = Input.GetAxisRaw("Horizontal"); // Get input for x-axis 
        playerBody.velocity = new Vector2(getInput * 7f, playerBody.velocity.y); // Calling constructor of Vector2 with an intialization list; this also affects speed of player
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(playerCollided.bounds.center, playerCollided.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

}