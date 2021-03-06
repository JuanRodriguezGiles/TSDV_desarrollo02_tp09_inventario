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
    public override void ItemText(ref string _text)
    {
        _text = name + "\n" + armorType.ToString() + " " + type.ToString() + "\n" + "Armor: " + armorValue + "\n" +
                "Weight: " + weight.ToString() + "\n" + "Durability " +
                durability.ToString();
    }
    public override int GetEquipmentSlot()
    {
        equipSlot = (int) armorType;
        return equipSlot;
    }
}