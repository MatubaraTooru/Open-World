using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [SerializeField] string _itemName = "None";
    [SerializeField] int _itemID = -1;
    [SerializeField] Sprite _itemImage = null;
    [SerializeField] string _itemDescription = "None";
    [SerializeField] ActionEffect _effect = ActionEffect.Recovery;
    [SerializeField] ActivationTiming _timing = ActivationTiming.use;
    public string Name { get => _itemName; }
    public int ID { get => _itemID; }
    public Sprite Image { get => _itemImage; }
    public string Description { get => _itemDescription; }
    

    enum ActionEffect
    {
        Recovery,
        PowerUp,
        DefenseUp,
        Damage
    }

    enum ActivationTiming
    {
        use,
    }
}
