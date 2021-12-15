using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for the object's movement (jump or walk)
/// </summary>

// LO1a - C# does not use header files as it runs on .NET
//LO4
// Procedural programming includes functions and is written and executed in sequential order as instructions
// Functional programming is similar to procedural but everything is inside of functions that interact with each other directly
// In OOP, data and code are enclosed together and divided into classes in order to produce objects

// LO1 - Design and implement a class
public class PlayerMovement : MonoBehaviour  // All scripts extend from this base class 
{
    private Rigidbody2D playerBody; // private because we don't want this to be directly accessible
    private BoxCollider2D playerCollided;

    [SerializeField] private LayerMask jumpableGround;
    /// <summary>
    /// Method is called when the game is started
    /// </summary>
    private void Start()
    {
        playerBody = gameObject.GetComponent<Rigidbody2D>(); // Targets the game object
        playerCollided = gameObject.GetComponent<BoxCollider2D>();

   
    }
    /// <summary>
    /// Method is called once per frame
    /// </summary>
    private void Update() 
    {
        PlayerWalk(); 
        PlayerJump();
       
    }
    /// <summary>
    /// Method for player to jump by pressing up arrow key
    /// </summary>
    private void PlayerJump() 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded()) // If the up arrow key is pressed
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, 10f); // Then target the object to jump
           
        }
    }
    /// <summary>
    ///Method that allows player to walk by pressing left and right arrow key 
    ///
    /// </summary>
    private void PlayerWalk()
    {
        float getInput = Input.GetAxisRaw("Horizontal"); // Get input for x-axis 
        playerBody.velocity = new Vector2(getInput * 7f, playerBody.velocity.y); // Calling constructor of Vector2 with an intialization list; this also affects speed of player
    }

    /// <summary>
    /// Method that checks is the object is collided with ground
    /// </summary>
    /// <returns>Returns true if object collides with ground </returns>
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(playerCollided.bounds.center, playerCollided.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

}
