using UnityEngine;
using UnityEngine.EventSystems;
public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string tooltipText;
    public void OnPointerEnter(PointerEventData eventData)
    {
        UIManager.Get().ShowTooltip(transform.position, tooltipText);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        UIManager.Get().HideTooltip();
    }
}