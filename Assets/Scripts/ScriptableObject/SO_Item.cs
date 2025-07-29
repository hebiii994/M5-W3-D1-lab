using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public abstract class SO_Item : ScriptableObject
{
    [SerializeField] private int _id;
    [SerializeField] private string _itemName;
    [SerializeField, TextArea(5, 10)] private string _description;
    [SerializeField] private Sprite _icon;

    public int ID => _id;
    public string ItemName => _itemName;
    public string Description => _description;
    public Sprite Icon => _icon;

    public abstract void Use(GameObject user);
}
