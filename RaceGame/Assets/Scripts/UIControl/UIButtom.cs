using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtom : MonoBehaviour
{
    public GameObject bagImage;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void bagControl()
    {
        if(bagImage.GetComponent<CanvasGroup>().alpha == 1)
        {
            bagImage.GetComponent<CanvasGroup>().alpha = 0;
            player.GetComponent<Move>().enabled = true;
            Time.timeScale = 1;
        }
        else if (bagImage.GetComponent<CanvasGroup>().alpha == 0)
        {
            bagImage.GetComponent<CanvasGroup>().alpha = 1;
            player.GetComponent<Move>().enabled = false;
            Time.timeScale = 0;
        }
    }

    
}
