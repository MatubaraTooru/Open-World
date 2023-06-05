using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShop : MonoBehaviour
{
    [SerializeField] ItemBase[] _itemArray;

    private void Awake()
    {
        var grid = GetComponent<GridLayoutGroup>();
    }
    void Start()
    {
        SetItem();
    }

    private void SetItem()
    {
        for (var i = 0; i < _itemArray.Length; i++)
        {
            var obj = new GameObject($"Button({i})");
            obj.transform.parent = transform;
            obj.AddComponent<Button>();

            var image = obj.AddComponent<Image>().sprite = _itemArray[i].Image;
        }
    }

    public void OnClicked()
    {
        Debug.Log("OnClicked");
    }
}
