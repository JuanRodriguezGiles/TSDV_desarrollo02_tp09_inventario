using UnityEngine;
public enum ItemType
{
    Consumable,
    Armor,
    Weapon
}
public class ItemObject : ScriptableObject
{
    public ItemType type;
    public GameObject worldObject;
    public Sprite uiImage;
    public string name;
    public int weight;
    public int durability;
    public int equipSlot;
    public virtual void ItemText(ref string _text){}
    public virtual int GetEquipmentSlot(){return 0;}
}