using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskEnemy : Enemy
{
    protected override void EnemyMovement()
    {
        transform.Rotate(360 * enemySpeed * Time.deltaTime, 180, 0); // rotate on the x-axis instead
    }

    public override void Introduction()
    {
        Debug.Log("Mask Enemy!");
    }
}
