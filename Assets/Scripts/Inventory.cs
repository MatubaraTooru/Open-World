using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] 
    private List<ItemParam> inventory = new List<ItemParam>();
    public void GetItem(ItemParam item)
    {
        inventory.Add(item);
    }
}
