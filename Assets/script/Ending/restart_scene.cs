using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_scene : MonoBehaviour {
    // Use this for initialization
    public void Restart_fail()
    {
        SceneManager.LoadScene("main");
    }
}
