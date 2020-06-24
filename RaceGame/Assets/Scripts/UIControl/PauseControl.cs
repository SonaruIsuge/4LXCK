using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    private bool isPause = false;
    public void pauseControl()
    {
        if (!isPause)
        {
            Time.timeScale = 0;
            isPause = !isPause;
        }
        else
        {
            Time.timeScale = 1;
            isPause = !isPause;
        }
    }
}
