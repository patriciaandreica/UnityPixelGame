using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Protected members are accessible in the same class or in the class that is inherited from it. 
// If derived from public base, then member can be accessible anywhere.
// If private, no members are inherited directly in any visibility mode; accessible only within the same class

[System.Serializable]
public abstract class Item 
{
   private  string itemDescription; 
   private string itemType;
   private int itemID;

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

    public Item(string description, int id) // This is showing constructor overloading as they have different parameter lists
    {
        this.itemDescription = description;
        this.itemID = id;
        this.itemType = "Unknown";
    }

    public string GetFullDescription() // Get fields 
    {
        string itemFullDescription = " ";
        itemFullDescription += "ID: " + this.itemID + " ";
        itemFullDescription += "Description " + this.itemDescription + " ";
        itemFullDescription += "Type: " + this.itemType;
        return itemFullDescription;
    }

   

}
