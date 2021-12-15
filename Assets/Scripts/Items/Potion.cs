using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is used as one of the items dervied from the base class Items
/// </summary>

public class Potion : Item
{
    [SerializeField] private string colorPotion { get; set; }

    public Potion(string color) // constructor
    {
        this.colorPotion = color;
    }
 
}
