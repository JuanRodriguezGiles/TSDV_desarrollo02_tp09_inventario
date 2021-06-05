using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> inventorySlots = new List<InventorySlot>();
    public void AddItem(ItemObject _item, int amount)
    {
        bool hasItem = false;
        foreach (InventorySlot slot in inventorySlots)
        {
            if (slot.item != _item) continue;
            slot.AddAmount(amount);
            hasItem = true;
            break;
        }
        if (!hasItem)
        {
            inventorySlots.Add(new InventorySlot(_item, amount));
        }
    }
}
[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int amount;
    public InventorySlot(ItemObject _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount += value;
    }
}