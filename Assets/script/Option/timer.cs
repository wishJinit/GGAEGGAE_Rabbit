using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

    public float time;
    start_cnt sc;
    // Use this for initialization
    void Start ()
    {
        sc = GameObject.Find("count").GetComponent<start_cnt>();
        time = 60f;
	}
	
	// Update is called once per frame
	void Update () {
        if (time != 0 && sc.gamestart)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 0;
            }
        }else if(time == 0)
        {
            SceneManager.LoadScene("game_over");
        }

        int t = Mathf.FloorToInt(time);
        Text uiText = GetComponent<Text>();
        uiText.text = t.ToString();
	}
}
