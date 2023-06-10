using UnityEngine;
using UnityEngine.UI;

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
            obj.AddComponent<Button>().onClick.AddListener(OnClicked);

            var image = obj.AddComponent<Image>().sprite = _itemData.itemParams[i].Image;
        }
    }

    public void OnClicked()
    {
        var image = GetComponent<Image>().sprite;
        for (int i = 0; i < _itemData.itemParams.Count; i++)
        {
            if (image == _itemData.itemParams[i].Image)
            {
                _playerInventory.GetItem(_itemData.itemParams[i]);
            }
        }
    }
}
