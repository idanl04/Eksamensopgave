using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    // Properties of the item
    public string itemName;
    public Sprite icon;
    public string description;
}