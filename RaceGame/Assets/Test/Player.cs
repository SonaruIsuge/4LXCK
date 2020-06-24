using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]List<Item> itemList = new List<Item>();
    [SerializeField] BagUI ui = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)&&itemList.Count!=0)
        {
            foreach(Item o in itemList)
            {
                if (o.type == EItemType.HEALTH_KIT)
                {
                    Debug.Log("Heal " + (o as HealthKit).value);
                }
                else
                    Debug.Log(o.type.ToString());
            }
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (col.gameObject.tag == "Item")
            {
                Item o = col.GetComponent<Item>();
                if (o != null)
                {
                    itemList.Add(o);
                    ui.AddItem(o);
                    col.gameObject.SetActive(false);
                    Debug.Log("Get" + o.type.ToString());
                }
            }
        }
    }
}
