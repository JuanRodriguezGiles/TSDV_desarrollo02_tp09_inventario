using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayInventory : MonoBehaviour
{
    public InventoryObject inventory;

    public int xStart;
    public int yStart;
    public int xSpaceBetweenItem;
    public int ySpaceBetweenItem;
    public int columns;

    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    void Start()
    {
        CreateDisplay();
    }
    void Update()
    {
        UpdateDisplay();
    }
    void UpdateDisplay()
    {
        for (int i = 0; i < inventory.container.Count; i++)
        {
            if (itemsDisplayed.ContainsKey(inventory.container[i]))
            {
                itemsDisplayed[inventory.container[i]].GetComponentInChildren<TextMeshProUGUI>().text =
                    inventory.container[i].amount.ToString();
            }
            else
            {
                var go = Instantiate(inventory.container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
                go.GetComponent<RectTransform>().localPosition = GetPosition(i);
                go.GetComponentInChildren<TextMeshProUGUI>().text = inventory.container[i].amount.ToString();
                itemsDisplayed.Add(inventory.container[i], go);
            }
        }
    }
    void CreateDisplay()
    {
        for (int i = 0; i < inventory.container.Count; i++)
        {
            var go = Instantiate(inventory.container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
            go.GetComponent<RectTransform>().localPosition = GetPosition(i);
            go.GetComponentInChildren<TextMeshProUGUI>().text = inventory.container[i].amount.ToString();
        }
    }
    Vector3 GetPosition(int i)
    {
        float x = xStart + xSpaceBetweenItem * (i % columns);
        float y = yStart + (-ySpaceBetweenItem * (i / columns));
        return new Vector3(x, y, 0);
    }
}