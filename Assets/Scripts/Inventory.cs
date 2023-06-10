using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] 
    private List<ItemParam> inventory = new List<ItemParam>();
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GetItem(ItemParam go)
    {
        inventory.Add(go);
    }
}
