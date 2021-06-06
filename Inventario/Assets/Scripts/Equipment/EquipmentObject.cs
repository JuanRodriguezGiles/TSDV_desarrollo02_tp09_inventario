using UnityEngine;
public enum EquipmentType
{
    Helm,
    Chest,
    Hands,
    Legs,
    Weapon
}
[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class EquipmentObject : ScriptableObject
{
    public EquipmentSlot[] equipmentSlots = new EquipmentSlot[5];
    void Awake()
    {
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            equipmentSlots[i] = new EquipmentSlot((EquipmentType)i);
        }
    }
    public void TryEquipItem(ItemObject _item)
    {
        if (_item.type == ItemType.Armor)
        {
            int armorType = _item.GetEquipmentSlot();
            equipmentSlots[armorType].item = _item;
        }

        if (_item.type == ItemType.Weapon)
        {
            equipmentSlots[equipmentSlots.Length - 1].item = _item;
        }
    }
}
[System.Serializable]
public class EquipmentSlot
{
    public ItemObject item;
    public EquipmentType equipmentType;
    public EquipmentSlot(EquipmentType _type)
    {
        item = null;
        equipmentType = _type;
    }
}