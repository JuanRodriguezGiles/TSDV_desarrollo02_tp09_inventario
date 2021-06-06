using UnityEngine;
using UnityEngine.EventSystems;
public class UnequipmentHandler : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] int _equipmentIndex;
    void Awake()
    {
        _equipmentIndex = transform.GetSiblingIndex();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            ItemObject item = GetComponentInParent<DisplayEquipment>().GetItem(_equipmentIndex);
            UIManager.Get().UnequipItem(item, _equipmentIndex);
        }
    }
}
