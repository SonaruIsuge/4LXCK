using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public static bool LightIsGotten = false;
    public static void Get(GameObject item)
    {
        if (Input.GetKey(KeyCode.E))
        {
            item.SetActive(false);
            if (item.CompareTag("light"))
            {
                LightIsGotten = true;
            }
        }
    }
}
