using UnityEngine;
[CreateAssetMenu(fileName = "Consumable Object", menuName = "Inventory/Items/Consumable")]
public class ConsumableObject : ItemObject
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.Consumable;
    }
    public override void itemText(ref string _text)
    {
        _text = name + "\n" + type.ToString() + "\n" + "Heals for: " + restoreHealthValue + "\n" +
                "Weight: " + weight.ToString() + "\n" + "Durability " +
                durability.ToString();
    }
}