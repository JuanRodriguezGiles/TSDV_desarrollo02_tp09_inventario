using UnityEngine;
public enum ArmorType
{
    Helm,
    Chest,
    Hands,
    Legs
}
[CreateAssetMenu(fileName = "Armor Object", menuName = "Inventory/Items/Armor")]
public class ArmorObject : ItemObject
{
    public ArmorType armorType;
    public int armorValue;
    void Awake()
    {
        type = ItemType.Armor;
    }
}