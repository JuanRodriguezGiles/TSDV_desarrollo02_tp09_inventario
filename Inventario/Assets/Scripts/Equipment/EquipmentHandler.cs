using UnityEngine;
using UnityEngine.EventSystems;
public class EquipmentHandler : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] int _inventoryIndex;
    void Awake()
    {
        _inventoryIndex = transform.GetSiblingIndex();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            ItemObject item = GetComponentInParent<DisplayInventory>().GetItem(_inventoryIndex);
            UIManager.Get().TryEquipItem(item);
        }
    }
}