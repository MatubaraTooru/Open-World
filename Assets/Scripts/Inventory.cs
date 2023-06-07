using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<GameObject> inventory = new List<GameObject>();
    public GameObject GO { get; set; }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GetItem(GameObject go)
    {
        inventory.Add(go);
    }
}
