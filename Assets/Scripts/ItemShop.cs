using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ItemShop : MonoBehaviour
{
    [SerializeField] ItemDataAsset _itemData;
    private Inventory _playerInventory;

    private void Awake()
    {
        var grid = GetComponent<GridLayoutGroup>();
        _playerInventory = FindAnyObjectByType<Inventory>();
    }
    void Start()
    {
        SetItem();
    }

    private void SetItem()
    {
        for (var i = 0; i < _itemData.itemParams.Count; i++)
        {
            var obj = new GameObject($"Button({i})");
            obj.transform.parent = transform;

            var itemID = _itemData.itemParams[i].ID;

            obj.AddComponent<Button>().onClick.AddListener(() => OnClicked(itemID));

            obj.AddComponent<Image>().sprite = _itemData.itemParams[i].Image;
        }
    }

    public void OnClicked(int itemID)
    {
        var itemParam = _itemData.itemParams.Find(item => item.ID == itemID);
        if (itemParam != null)
        {
            _playerInventory.GetItem(itemParam);
        }
    }
}
