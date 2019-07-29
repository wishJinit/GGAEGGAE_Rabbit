using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiger_control : MonoBehaviour {
    public moonclick_count moon;

    public GameObject dontmoon;
    public GameObject t_head; 
    public GameObject t_foot_1;
    public GameObject t_foot_2;
    public GameObject t_foot_3;
    public GameObject t_foot_4;

    public GameObject t_nail_1;
    public GameObject t_nail_2;
    public GameObject t_nail_3;
    public GameObject t_nail_4;

    public GameObject l_rabbit;
    public GameObject r_rabbit;
    public GameObject l_hammer;
    public GameObject r_hammer;

    public GameObject text;

    public int t_nail_rand = 0; 

    public bool tiger_appear = false;
    public bool f_flag = false;

    void Start () {
        moon = GameObject.Find("Moon").GetComponent<moonclick_count>();  //moonclick_count스크립트가 연결된 객체 중 Moon태그인것을 참조하게 하는 변수
        hide();
    }

	public void Update ()
    {
        if (moon.count == 160) ///////////////////////////////////////////////////////////////
        {
            if (!tiger_appear)
            {
                show_tiger();
                tiger_appear = true;
            }
        }
        
    }
    
    void show_tiger()
    {
        l_rabbit.transform.position = new Vector3(-751, (float)116.55f, 0);
        r_rabbit.transform.position = new Vector3(-751, (float)116.55f, 0);
        l_hammer.transform.position = new Vector3(-751, (float)116.55f, 0);
        r_hammer.transform.position = new Vector3(-751, (float)116.55f, 0);

            dontmoon.transform.position = new Vector3(540, 810, 0);
            t_head.transform.position = new Vector3(540, 1090, 0);          
            t_foot_1.transform.position = new Vector3(710, 970, 0);
            t_foot_2.transform.position = new Vector3(380, 970, 0);
            t_foot_3.transform.position = new Vector3(380, 650, 0);
            t_foot_4.transform.position = new Vector3(710, 650, 0);

            StartCoroutine(foot_click());
    }
    IEnumerator foot_click()
    {
        for (int i = 0; i < 30; i++)
        {
            text.transform.position = new Vector3(540, 200);
            if (i > 2)
            {
                text.transform.position = new Vector3(-751, (float)116.55f, 0);
            }
            t_nail_rand = Random.Range(1, 5);
            f_flag = false;
            switch (t_nail_rand)
            {
                case 1:
                    t_nail_1.transform.position = new Vector3(695, 950, 0);
                    while (!f_flag)
                    {
                        yield return new WaitForSeconds(0.1f);
                    }
                    break;
                case 2:
                    t_nail_2.transform.position = new Vector3(395, 950, 0);
                    while (!f_flag)
                    {
                        yield return new WaitForSeconds(0.1f);
                    }
                    break;
                case 3:
                    t_nail_3.transform.position = new Vector3(398, 668, 0);
                    while (!f_flag)
                    {
                        yield return new WaitForSeconds(0.1f);
                    }
                    break;
                case 4:
                    t_nail_4.transform.position = new Vector3(692, 668, 0);
                    while (!f_flag)
                    {
                        yield return new WaitForSeconds(0.1f);
                    }
                    break;
            }
        }
        hide();
        l_rabbit.transform.position = new Vector3(235, 1005, 0);
        r_rabbit.transform.position = new Vector3(845, 1005, 0);
        l_hammer.transform.position = new Vector3(225, 1010, 0);
        r_hammer.transform.position = new Vector3(855, 1010, 0);
        dontmoon.transform.position = new Vector3(0, -400, 0);
    }

    void hide()
    {
        
        t_head.transform.position = new Vector3(0, -300,0);

        t_foot_1.transform.position = new Vector3(0, -300, 0);
        t_foot_2.transform.position = new Vector3(0, -300, 0);
        t_foot_3.transform.position = new Vector3(0, -300, 0);
        t_foot_4.transform.position = new Vector3(0, -300, 0);

        t_nail_1.transform.position = new Vector3(0, -300, 0);
        t_nail_2.transform.position = new Vector3(0, -300, 0);
        t_nail_3.transform.position = new Vector3(0, -300, 0);
        t_nail_4.transform.position = new Vector3(0, -300, 0);
    }
}
