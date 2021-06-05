using TMPro;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    #region INSTANCE
    private static GameManager instance;
    public static GameManager Get()
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
    public GameObject toolTip;
    int _index;
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.F)) return;

        _index = Random.Range(0, items.itemsList.Count);
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
}