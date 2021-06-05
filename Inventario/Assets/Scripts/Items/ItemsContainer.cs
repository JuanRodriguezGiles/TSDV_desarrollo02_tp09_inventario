using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Items Container", menuName = "Inventory/Items/Item Container")]
public class ItemsContainer : ScriptableObject
{
    public List<ItemObject> itemsList;
    void Awake()
    {
        itemsList = new List<ItemObject>();
    }
}