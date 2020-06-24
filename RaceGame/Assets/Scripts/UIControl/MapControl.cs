using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapControl : MonoBehaviour
{
    public static bool mapIsActive = false;
    public RawImage MapImage;
    public Camera MiniCamera;
    private GameObject player;

    void Start()
    {
        MapImage.enabled = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void ShowMap()
    {
        if (!mapIsActive)
        {
            mapIsActive = !mapIsActive;
            MapImage.enabled = true;
            Time.timeScale = 0;
            MiniCamera.GetComponent<Camera>().orthographicSize = 108.0f;
            MiniCamera.transform.position = new Vector3(0, 50, 0);
        }

        else
        {
            mapIsActive = !mapIsActive;
            MapImage.enabled = false;
            Time.timeScale = 1;
            MiniCamera.GetComponent<Camera>().orthographicSize = 12.0f;
            MiniCamera.transform.position = new Vector3(player.transform.position.x, 50, player.transform.position.z);
        }
    }
}
