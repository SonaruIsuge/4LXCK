using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    //控制燈亮
    public Light flashLight;
    //玩家
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        flashLight.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashLight.enabled = !flashLight.enabled;
            }

    }


}
