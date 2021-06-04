using UnityEngine;
public class Player : MonoBehaviour
{
    public InventoryObject inventory;

    void OnTriggerEnter(Collider col)
    {
        var item = col.GetComponent<Item>();

        if (!item) return;
        inventory.AddItem(item.item, 1);
        Destroy(col.gameObject);
    }
}