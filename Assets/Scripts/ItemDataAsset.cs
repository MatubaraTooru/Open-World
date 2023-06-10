using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/CreateItemDataAsset")]
public class ItemDataAsset : ScriptableObject
{
    public List<ItemParam> itemParams = new List<ItemParam>();
}

[System.Serializable]
public class ItemParam
{
    [SerializeField, Header("アイテムの名前")]
    private string _itemName = "None";

    [SerializeField, Header("アイテムの名前ID"), Tooltip("重複の無いように設定する")]
    private int _itemID = -1;

    [SerializeField, Header("アイテムの画像"), Tooltip("これがないとアイテムショップに画像が表示されない")]
    private Sprite _itemImage = null;

    [SerializeField, Header("アイテムの効果")]
    private ActionEffect _effect = ActionEffect.Recovery;

    [SerializeField, Header("アイテムの使用タイミング")]
    private ActivationTiming _timing = ActivationTiming.Use;

    public string Name { get => _itemName; }
    public int ID { get => _itemID; }
    public Sprite Image { get => _itemImage; }


    enum ActionEffect
    {
        Recovery, // 回復
        PowerUp, // 攻撃力上昇
        DefenseUp, // 防御力上昇
    }

    enum ActivationTiming
    {
        /// <summary> インベントリにから直接使用し、その瞬間効果が発動する </summary>
        Use,
        /// <summary> アイテムをプレイヤーに装備し、アイテムの効果を装備中持続させる</summary>
        Equipment
    }
}
