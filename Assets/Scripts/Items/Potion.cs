using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Item
{
    [SerializeField] private string colorPotion;

    public Potion(string color)
    {
        this.colorPotion = color;
    }
}
