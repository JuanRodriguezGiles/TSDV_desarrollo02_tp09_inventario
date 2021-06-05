using UnityEngine;
using UnityEngine.EventSystems;
public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string tooltipText;
    public void OnPointerEnter(PointerEventData eventData)
    {
        GameManager.Get().ShowTooltip(transform.position, tooltipText);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        GameManager.Get().HideTooltip();
    }
}