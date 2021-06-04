﻿using UnityEngine;
[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public int attackBonus;
    public int defenceBonus; 
    void Awake()
    {
        type = ItemType.Equipment;
    }
}