using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemUI : MonoBehaviour
{
    public Item item;
    public TMP_Text temName;

    void OnEnable()
    {
        temName.text = item.itemInfo.m_name;
    }

    public void OnClickHandler()
    {
        item.Use();
        Destroy(gameObject);
        Destroy(item.gameObject);
    }
}
