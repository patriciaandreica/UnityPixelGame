using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Generic type
public class Generic : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>(); // List of type Item

    private void Start()
    {
        items.Add(new Potion("Red")); 
        items.Add(new Weapon(50));
        items.Add(new Potion("Blue"));
        items.Add(new Weapon(30));
        
        List<Item> listWeapons = GetItemsType<Weapon>(); // Weapon class is passed as argument
        List<Item> listPotions = GetItemsType<Potion>(); // Potion can also be passed

    }
    private List<Item> GetItemsType<T>() where T : Item   // Take any type derived from Item
    {
        List<Item> itemsToReturn = new List<Item>(); 
        for(int i = 0; i < items.Count; i++) // Loop through items
        {
            if(items[i] is T) // Current item is type T
            {
                itemsToReturn.Add(items[i]); // Add item to list
            }
        }
        return itemsToReturn;
    }
}
