using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moonclick_count : MonoBehaviour
{
    public int count = 0;
    start_cnt sc;
    public start_cnt startcnt;
    public GameObject dontmoon;
    public void Start()
    {
        dontmoon = GameObject.FindGameObjectWithTag("dontmoon");
        sc = GameObject.Find("count").GetComponent<start_cnt>();
    }

    public void Click()
    {
        if (sc.gamestart)
        {
            count++;
        }
    }
    public void Update()
    {
        if (count == 200)
        {
            SceneManager.LoadScene("game_clear");
        }
    }
}
   

