using UnityEngine;
using Character;

public abstract class ItemScriptables : ScriptableObject
{
    public string Name = "Item";
    public ItemCategory ItemCategory = ItemCategory.None;
    public GameObject ItemPrefab;
    public bool Stackable;
    public int MaxStack = 1;

    public int Amount => m_Amount;
    private int m_Amount;

    private PlayerController Controller { get; set; }

    public void Initialize(PlayerController controller)
    {

    }

    public abstract void UseItem(PlayerController controller);

    public virtual void DeleteItem(PlayerController controller)
    {

    }

    public virtual void DropItem(PlayerController controller)
    {

    }

    public void ChangeAmount(int amount)
    {
        m_Amount += amount;
    }

    public void SetAmount(int amount)
    {
        m_Amount = amount;
    }
}
