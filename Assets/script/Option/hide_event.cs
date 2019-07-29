using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class hide_event : MonoBehaviour {
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("start");
        }
        if (Input.touchCount >= 1)
        {
            SceneManager.LoadScene("start");
        }
    }
    
    public void back()
    {
        SceneManager.LoadScene("start");
    }
}
