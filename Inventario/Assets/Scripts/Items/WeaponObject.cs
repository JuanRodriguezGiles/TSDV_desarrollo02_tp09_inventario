using UnityEngine;
public enum WeaponType
{
    Sword,
    Mace,
    Spear,
    Axe
}
[CreateAssetMenu(fileName = "Weapon Object", menuName = "Inventory/Items/Weapon")]
public class WeaponObject : ItemObject
{
    public WeaponType weaponType;
    public int attackValue;
    void Awake()
    {
        type = ItemType.Weapon;
    }
    public override void ItemText(ref string _text)
    {
        _text = name + "\n" + weaponType.ToString() + " " + type.ToString() + "\n" + "Attack: " + attackValue + "\n" +
                "Weight: " + weight.ToString() + "\n" + "Durability " +
                durability.ToString();
    }
}