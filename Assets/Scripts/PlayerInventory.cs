using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlayerInventory : MonoBehaviour
{
    public event Action OnInventoryChanged;

    [SerializeField] private List<SO_Item> _items = new List<SO_Item>();

    public List<SO_Item> Items => _items;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) UseItem(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) UseItem(1);
    }

    public void AddItem(SO_Item item)
    {
        _items.Add(item);
        Debug.Log($"aggiunto {item.ItemName}. adesso possiedi {_items.Count}");
        OnInventoryChanged?.Invoke();
    }

    public void UseItem(int itemIndex)
    {
        if (itemIndex >= 0 && itemIndex < _items.Count)
        {
            SO_Item itemToUse = _items[itemIndex];
            itemToUse.Use(this.gameObject);
            _items.RemoveAt(itemIndex);
            OnInventoryChanged?.Invoke();
        }
    }
}
