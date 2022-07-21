using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    List<Item> m_items = new List<Item>();

    public void AddItem(Item item)
    {
        m_items.Add(item);
    }

    public Item RemoveItem(Item item)
    {
        if (m_items.Contains(item))
        {
            m_items.Remove(item);
            return item;
        }
        return null;
    }

    public Item[] GetItems()
    {
        return m_items.ToArray();
    }
}
