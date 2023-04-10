using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemParent;
    public GameObject itemPrefab;

    private InventoryManager inventoryManager;

    private void Start()
    {
        inventoryManager = GetComponent<InventoryManager>();
        UpdateUI();
    }

    private void UpdateUI()
    {
        // Clear the UI
        foreach (Transform child in itemParent)
        {
            Destroy(child.gameObject);
        }

        // Add UI elements for each item in the inventory
        foreach (Item item in inventoryManager.GetInventoryItems())
        {
            GameObject newItem = Instantiate(itemPrefab, itemParent);
            newItem.GetComponent<Image>().sprite = item.icon;
            newItem.GetComponentInChildren<Text>().text = item.itemName;
            newItem.GetComponent<Button>().onClick.AddListener(() => UseItem(item));
        }
    }

    private void UseItem(Item item)
    {
        ItemUse itemUse = GetComponent<ItemUse>();
        if
    }

}