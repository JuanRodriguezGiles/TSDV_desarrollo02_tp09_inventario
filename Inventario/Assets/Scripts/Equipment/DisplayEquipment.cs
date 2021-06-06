using UnityEngine;
using UnityEngine.UI;
public class DisplayEquipment : MonoBehaviour
{
    public EquipmentObject equipment;
    public Sprite defaultImage;
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
        for (int i = 0; i < equipment.equipmentSlots.Length; i++)
        {
            if (equipment.equipmentSlots[i].item)
            {
                transform.GetChild(i).GetComponent<Image>().sprite = equipment.equipmentSlots[i].item.uiImage;
                equipment.equipmentSlots[i].item
                    .ItemText(ref transform.GetChild(i).GetComponent<Tooltip>().tooltipText);
            }
            else
            {
                transform.GetChild(i).GetComponent<Image>().sprite = defaultImage;
            }
        }
    }
    void UpdateDisplay()
    {
        for (int i = 0; i < equipment.equipmentSlots.Length; i++)
        {
            if (equipment.equipmentSlots[i].item)
            {
                transform.GetChild(i).GetComponent<Image>().sprite = equipment.equipmentSlots[i].item.uiImage;
                equipment.equipmentSlots[i].item
                    .ItemText(ref transform.GetChild(i).GetComponent<Tooltip>().tooltipText);
            }
            else
            {
                transform.GetChild(i).GetComponent<Image>().sprite = defaultImage;
                transform.GetChild(i).GetComponent<Tooltip>().tooltipText = "";
            }
        }
    }
    public ItemObject GetItem(int _index)
    {
        return equipment.equipmentSlots[_index].item;
    }
}