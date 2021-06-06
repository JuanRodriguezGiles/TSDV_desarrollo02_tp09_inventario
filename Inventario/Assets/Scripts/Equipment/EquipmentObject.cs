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
            if (equipmentSlots[i].item)
                equipmentSlots[i].equipped = true;
        }
    }
    public bool TryEquipItem(ItemObject _item)
    {
        if (_item.type == ItemType.Armor)
        {
            int armorType = _item.GetEquipmentSlot();
            if (equipmentSlots[armorType].equipped)
            {
                UIManager.Get().AddItem(equipmentSlots[armorType].item);
            }
            equipmentSlots[armorType].item = _item;
            equipmentSlots[armorType].equipped = true;
            return true;
        }

        if (_item.type == ItemType.Weapon)
        {
            if (equipmentSlots[equipmentSlots.Length - 1].equipped)
            {
                UIManager.Get().AddItem(equipmentSlots[equipmentSlots.Length - 1].item);
            }
            equipmentSlots[equipmentSlots.Length - 1].item = _item;
            equipmentSlots[equipmentSlots.Length - 1].equipped = true;
            return true;
        }

        return false;
    }
    public void UnequipItem(ItemObject _item, int _index)
    {
        equipmentSlots[_index].item = null;
        equipmentSlots[_index].equipped = false;
    }
}
[System.Serializable]
public class EquipmentSlot
{
    public ItemObject item;
    public EquipmentType equipmentType;
    public bool equipped;
    public EquipmentSlot(EquipmentType _type)
    {
        item = null;
        equipped = false;
        equipmentType = _type;
    }
}