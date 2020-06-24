using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCameraControll : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!MapControl.mapIsActive)
        {
            transform.position = new Vector3(player.transform.position.x, 50, player.transform.position.z);
        }
    }
}
