using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is another item derived from base class Item
/// </summary>

public class Weapon : Item
{
    [SerializeField] private int damageAmount;

    public Weapon(int damage)
    {
        this.damageAmount = damage;
    }
}
