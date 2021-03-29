using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryComponent : MonoBehaviour
{
    [SerializeField] private List<ItemScriptables> Items = new List<ItemScriptables>();

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum ItemCategory
{
    None,
    Weapon,
    Equipment,
    Consumable,
    Ammo
}