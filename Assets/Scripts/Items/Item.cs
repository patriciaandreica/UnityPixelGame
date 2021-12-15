using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Not the most efficient use in this case, but I using this 
///  class to show how to implement constructors. Constructors should not be used to intialize 
///  monobehaviours.
/// </summary>

// LO2
// Protected members are accessible in the same class or in the class that is inherited from it. 
// If derived from public base class, then member can be accessible anywhere in other classes.
// If private, no members are inherited directly in any visibility mode; accessible only within the same class

[System.Serializable] // Have to use this as this class does not inherit from anything so it doesn't live on anything
// LO6
public abstract class Item
{
    private string itemDescription {get; set;}  // private members
    private string itemType { get; set; }
    private int itemID { get; set; }

    public Item() // Default constructor 
    {
        this.itemDescription = "Unknown";
        this.itemType = "Unknown";
        this.itemID = 0;
    }

    public Item(string description, string type, int id) // Paramterized constructor
    {
        this.itemDescription = description;
        this.itemType = type;
        this.itemID = id;
    }

    //LO1b
    public Item(string description, int id) // This is showing constructor overloading as they have different parameter lists
    {
        this.itemDescription = description;
        this.itemID = id;
        this.itemType = "Unknown";
    }

    /// <summary>
    /// Method to print out the full descriptions for the item
    /// </summary>
    /// <returns>Return the full item description</returns>

    public string GetFullDescription() // Get fields 
    {
        string itemFullDescription = " ";
        itemFullDescription += "ID: " + this.itemID + " ";
        itemFullDescription += "Description " + this.itemDescription + " ";
        itemFullDescription += "Type: " + this.itemType;
        return itemFullDescription;
    }
}
