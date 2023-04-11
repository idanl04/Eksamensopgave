using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour
{
    public Item item;

    public void UseItem()
    {
        InventoryManager inventoryManager = GetComponent<InventoryManager>();
        if (inventoryManager != null && inventoryManager.HasItem(item))
        {
            inventoryManager.RemoveItem(item);
            // Implement the item's functionality here
        }
    }
}