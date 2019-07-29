using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_but : MonoBehaviour {

    private bool isPause = true;
	
    void click()
    {
        if (isPause)
        {
            Time.timeScale = 0;
            isPause = false;
        }
        else
        {
            Time.timeScale = 1;
            isPause = true;
        }
    }
}
