using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class show_event : MonoBehaviour {
    // Use this for initialization
    public void show()
    {
        SceneManager.LoadScene("event");
    }
}
