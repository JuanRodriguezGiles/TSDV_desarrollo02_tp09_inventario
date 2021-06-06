using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DisplayInventory : MonoBehaviour
{
    public InventoryObject inventory;
    public GameObject slotUi;

    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    void Start()
    {
        CreateDisplay();
    }
    void Update()
    {
        UpdateDisplay();
    }
    void CreateDisplay()
    {
        for (int i = 0; i < inventory.inventorySlots.Count; i++)
        {
            GameObject go = Instantiate(slotUi, Vector3.zero, Quaternion.identity, transform);
            go.GetComponent<Image>().sprite = inventory.inventorySlots[i].item.uiImage;
            inventory.inventorySlots[i].item.ItemText(ref go.GetComponent<Tooltip>().tooltipText);
            go.GetComponentInChildren<TextMeshProUGUI>().text = inventory.inventorySlots[i].amount.ToString();

            itemsDisplayed.Add(inventory.inventorySlots[i], go);
        }
    }
    void UpdateDisplay()
    {
        for (int i = 0; i < inventory.inventorySlots.Count; i++)
        {
            if (itemsDisplayed.ContainsKey(inventory.inventorySlots[i]))
            {
                itemsDisplayed[inventory.inventorySlots[i]].GetComponentInChildren<TextMeshProUGUI>().text =
                    inventory.inventorySlots[i].amount.ToString();
            }
            else
            {
                GameObject go = Instantiate(slotUi, Vector3.zero, Quaternion.identity, transform);
                go.GetComponent<Image>().sprite = inventory.inventorySlots[i].item.uiImage;
                inventory.inventorySlots[i].item.ItemText(ref go.GetComponent<Tooltip>().tooltipText);
                go.GetComponentInChildren<TextMeshProUGUI>().text = inventory.inventorySlots[i].amount.ToString();

                itemsDisplayed.Add(inventory.inventorySlots[i], go);
            }
        }
    }
    public ItemObject GetItem(int _index)
    {
        return inventory.inventorySlots[_index].item;
    }
}