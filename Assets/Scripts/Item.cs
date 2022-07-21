using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemInfo itemInfo;

    public void Use()
    {
        Debug.Log("Item used");
    }
}