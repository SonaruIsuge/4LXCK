using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagUI : MonoBehaviour
{
    [SerializeField]List<Text> bagList = new List<Text>();
    List<Item> items = new List<Item>();
    public void AddItem(Item item)
    {
        items.Add(item);
        UpdateUI();
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        UpdateUI();
    }

    void UpdateUI()
    {
        for(int i = 0; i < items.Count; i++)
        {
            bagList[i].text = items[i].type.ToString();
        }
    }
}
