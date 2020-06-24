using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKey(KeyCode.LeftControl))
       // {
           // Cursor.visible = true;
       // }
       // else Cursor.visible = false;

        //this.gameObject.transform.position = offset + player.transform.position;

    }
}
