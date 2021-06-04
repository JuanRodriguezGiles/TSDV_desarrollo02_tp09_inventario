﻿using UnityEngine;
public enum ItemType
{
    Consumable,
    Equipment,
    Default
}
public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    public string name;
    public int weight;
    public int durability;
}