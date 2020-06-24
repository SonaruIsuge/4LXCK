using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float rotatespeed;
    public Rigidbody rb;
    public GameObject lightInPlayer;
    // Start is called before the first frame update
    void Start()
    {
        lightInPlayer.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            //transform.eulerAngles = new Vector3(0, 0, 0);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.eulerAngles = new Vector3(0, 180, 0);
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.eulerAngles = new Vector3(0, 270, 0);
            transform.Rotate(0, -rotatespeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.eulerAngles = new Vector3(0, 90, 0);
            transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
        }

        if (GetItem.LightIsGotten)
        {
            lightInPlayer.SetActive(true);
        }
        
    }

}
