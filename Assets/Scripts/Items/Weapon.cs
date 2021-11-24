using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    [SerializeField] int damageAmount;

    public Weapon(int damage)
    {
        this.damageAmount = damage;
    }
}
