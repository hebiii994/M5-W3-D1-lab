using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private PlayerInventory _playerInventory;
    [SerializeField] private Image _itemSlotImage;


    private void OnEnable()
    {
        _playerInventory.OnInventoryChanged += UpdateUI;
    }

    private void OnDisable()
    {
        _playerInventory.OnInventoryChanged -= UpdateUI;
    }

    private void Start()
    {
        UpdateUI();
    }
    private void UpdateUI()
    {
        
        if (_playerInventory.Items.Count > 0)
        {
           
            _itemSlotImage.sprite = _playerInventory.Items[0].Icon;
            _itemSlotImage.enabled = true; 
        }
        else
        {
            _itemSlotImage.enabled = false;
        }
    }
}
