using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryTest : MonoBehaviour
{
    public GameObject itemUI;
    public GameObject itemList;

    public Item healthPotion;
    public Item manaPotion;

    private Inventory m_playerInventory;

    void Start()
    {
        m_playerInventory = GetComponent<Inventory>();
    }

    void Update()
    {
        // TODO: implements the addition and removal of items in inventory
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Health potion given to player");
            Item ga = Instantiate(healthPotion);
            AddItemToInventory(ga);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("Mana potion given to player");
            Item ga = Instantiate(manaPotion);
            AddItemToInventory(ga);
        }
    }

    private void AddItemToInventory(Item item)
    {
        m_playerInventory.AddItem(item);
        AddItemToUI(item);
    }

    private void AddItemToUI(Item item)
    {
        GameObject instancedItemUI = Instantiate(itemUI);
        ItemUI itemUIComponent = instancedItemUI.GetComponent<ItemUI>();
        itemUIComponent.item = item;
        instancedItemUI.transform.SetParent(itemList.transform);
        instancedItemUI.SetActive(true);
    }
}
