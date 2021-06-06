using UnityEngine;
using UnityEngine.UI;
public class DisplayEquipment : MonoBehaviour
{
    public EquipmentObject equipment;
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
        }
    }
}