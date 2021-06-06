using TMPro;
using UnityEngine;
public class UIManager : MonoBehaviour
{
    #region INSTANCE
    private static UIManager instance;
    public static UIManager Get()
    {
        return instance;
    }
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    #endregion
    public ItemsContainer items;
    public InventoryObject inventory;
    public EquipmentObject equipment;
    public GameObject toolTip;

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.F)) return;

        int _index = Random.Range(0, items.itemsList.Count);
        inventory.AddItem(items.itemsList[_index], 1);
    }
    public void ShowTooltip(Vector3 position, string text)
    {
        toolTip.SetActive(true);
        toolTip.transform.position = position;
        toolTip.GetComponentInChildren<TextMeshProUGUI>().text = text;
    }
    public void HideTooltip()
    {
        toolTip.SetActive(false);
    }
    public void TryEquipItem(ItemObject _item)
    {
        equipment.TryEquipItem(_item);
    }
}