using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foot_but : MonoBehaviour
{
    public tiger_control tc;
    public int Me;
    timer t;
    public GameObject minus;
    
    void Start()
    {
        tc = GameObject.Find("head").GetComponent<tiger_control>();
        t = GameObject.FindWithTag("time").GetComponent<timer>();
    }

public void click()
    {
        if (tc.t_nail_rand == Me)
        {
            tc.f_flag = true; //클릭한 발이 맞다면
           
            switch (tc.t_nail_rand)
            {
                case 1:
                    tc.t_nail_1.transform.position = new Vector3(0, -300, 0);
                    break;
                case 2:
                    tc.t_nail_2.transform.position = new Vector3(0, -300, 0);
                    break;
                case 3:
                    tc.t_nail_3.transform.position = new Vector3(0, -300, 0);
                    break;
                case 4:
                    tc.t_nail_4.transform.position = new Vector3(0, -300, 0);
                    break;
            }
        }
        else
        {
            t.time -= 2f;
            StartCoroutine(Minus_cnt());
        }

    }
    private IEnumerator Minus_cnt()
    {
        minus.transform.position = new Vector3(591, 1444, 0);
        while (minus.transform.position.y< 1500)
        {
            minus.transform.position += new Vector3(0, 3f, 0);
            yield return new WaitForSeconds(0.01f);
        }
        minus.transform.position = new Vector3(1500, 1444, 0);
    }
}