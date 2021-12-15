using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// MaskEnemy is inheriting from Enemy because it "is a" type of Enemy. The purpose of this class is 
/// to give it different movements, so it overrides from the base class.
/// </summary>

// LO2 - Inheritance
public class MaskEnemy : Enemy
{
    //LO5 - Overriding

    /// <summary>
    /// Method overrides base class movememnt method to move differently
    /// </summary>
    protected override void EnemyMovement()
    {
        transform.Rotate(360 * enemySpeed * Time.deltaTime, 180, 0); // rotate on the x-axis instead
    }
    /// <summary>
    /// Introduction for MaskEnemy
    /// </summary>
    public override void Introduction()
    {
        Debug.Log("Mask Enemy!");
    }
}
