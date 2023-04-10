using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // List of items in the inventory
    private List<Item> inventory = new List<Item>();

    // Add an item to the inventory
    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    // Remove an item from the inventory
    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
    }

    // Check if an item is in the inventory
    public bool HasItem(Item item)
    {
        return inventory.Contains(item);
    }

    // Get a list of all the items in the inventory
    public List<Item> GetInventoryItems()
    {
        return inventory;
    }
}