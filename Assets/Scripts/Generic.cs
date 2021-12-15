using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is a generic type for items to create a list
/// </summary>
public class Generic : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>(); // List of type Item

    private void Start()
    {
        items.Add(new Potion("Red"));  // pass to constructor and add red poition
        items.Add(new Weapon(50));
        items.Add(new Potion("Blue"));
        items.Add(new Weapon(30));
        
        List<Item> listWeapons = GetItemsType<Weapon>(); // Weapon class is passed as argument
        List<Item> listPotions = GetItemsType<Potion>(); // Potion can also be passed

    }
    /// <summary>
    /// This is a generic method used for creating a list based on type T
    /// </summary>
    /// <typeparam name="T">Any type of item </typeparam>
    /// <returns>A list of items depending on type</returns>
    private List<Item> GetItemsType<T>() where T : Item   // Take any type derived from Item
    {
        List<Item> returnItems = new List<Item>(); 
        for(int i = 0; i < items.Count; i++) // Loop through items
        {
            if(items[i] is T) // Current item is type T
            {
                returnItems.Add(items[i]); // Add item to list
            }
        }
        return returnItems;
    }
}
