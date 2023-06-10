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
    [SerializeField, Header("�A�C�e���̖��O")]
    private string _itemName = "None";

    [SerializeField, Header("�A�C�e���̖��OID"), Tooltip("�d���̖����悤�ɐݒ肷��")]
    private int _itemID = -1;

    [SerializeField, Header("�A�C�e���̉摜"), Tooltip("���ꂪ�Ȃ��ƃA�C�e���V���b�v�ɉ摜���\������Ȃ�")]
    private Sprite _itemImage = null;

    [SerializeField, Header("�A�C�e���̌���")]
    private ActionEffect _effect = ActionEffect.Recovery;

    [SerializeField, Header("�A�C�e���̎g�p�^�C�~���O")]
    private ActivationTiming _timing = ActivationTiming.Use;

    public string Name { get => _itemName; }
    public int ID { get => _itemID; }
    public Sprite Image { get => _itemImage; }


    enum ActionEffect
    {
        Recovery, // ��
        PowerUp, // �U���͏㏸
        DefenseUp, // �h��͏㏸
    }

    enum ActivationTiming
    {
        /// <summary> �C���x���g���ɂ��璼�ڎg�p���A���̏u�Ԍ��ʂ��������� </summary>
        Use,
        /// <summary> �A�C�e�����v���C���[�ɑ������A�A�C�e���̌��ʂ𑕔�������������</summary>
        Equipment
    }
}
