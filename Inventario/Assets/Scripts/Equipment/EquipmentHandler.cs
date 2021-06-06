using UnityEngine;
using UnityEngine.EventSystems;
public class EquipmentHandler : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] int _inventoryIndex;
    void Awake()
    {
       UpdateIndex();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            _inventoryIndex = transform.GetSiblingIndex();
            ItemObject item = GetComponentInParent<DisplayInventory>().GetItem(_inventoryIndex);
            UIManager.Get().TryEquipItem(item);
        }
    }
    void UpdateIndex()
    {
        _inventoryIndex = transform.GetSiblingIndex();
    }
}