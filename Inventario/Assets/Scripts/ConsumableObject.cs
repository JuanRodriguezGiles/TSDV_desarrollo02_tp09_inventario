﻿using UnityEngine;
[CreateAssetMenu(fileName = "New Consumable Object", menuName = "Inventory/Items/Consumable")]
public class ConsumableObject : ItemObject
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.Consumable;
    }
}
