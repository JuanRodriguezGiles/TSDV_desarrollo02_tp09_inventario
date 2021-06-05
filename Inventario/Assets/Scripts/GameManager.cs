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
    int _index;
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.F)) return;

        _index = Random.Range(0, items.itemsList.Count);
        inventory.AddItem(items.itemsList[_index], 1);
    }
}