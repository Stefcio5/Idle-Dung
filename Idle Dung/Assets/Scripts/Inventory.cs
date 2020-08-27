using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Item> items;
    [SerializeField] private Transform itemParents;
    [SerializeField] private ItemSlot[] itemSlots;

    private void OnValidate()
    {
        if (itemParents != null)
        {
            itemSlots = itemParents.GetComponentsInChildren<ItemSlot>();
            RefreshUI();
        }
    }

    private void RefreshUI()
    {
        int i = 0;
        for (; i < items.Count && i < itemSlots.Length; i++)
        {
            itemSlots[i].Item = items[i];
        }

        for (; i < itemSlots.Length; i++)
        {
            itemSlots[i].Item = null;
        }
    }
}