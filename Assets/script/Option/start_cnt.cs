using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_cnt : MonoBehaviour {

    public GameObject one, two, three, start, dontmoon;
    public GameObject context;
    public bool gamestart;

    // Use this for initialization
    void Start()
    {
        dontmoon = GameObject.FindGameObjectWithTag("dontmoon");
        gamestart = false;
        StartCoroutine(scale_edit());
    }
    private IEnumerator scale_edit()
    {
        context.transform.position = new Vector3(550, 220, 0);
        dontmoon.transform.position = new Vector3(540, 810, 0);
        three.transform.position = new Vector3(535f, 810f, 0f);
        while (three.transform.localScale.x >= 0.5f)
        {
            three.transform.localScale -= new Vector3(0.03f, 0.03f, 0f);
            yield return new WaitForSeconds(0.05f);
        }
        Destroy(three);
        //three

        two.transform.position = new Vector3(535f, 810f, 0f);
        while (two.transform.localScale.x >= 0.5f)
        {
            two.transform.localScale -= new Vector3(0.03f, 0.03f, 0f);
            yield return new WaitForSeconds(0.05f);
        }
        Destroy(two);
        //two

        one.transform.position = new Vector3(535f, 810f, 0f);
        while (one.transform.localScale.x >= 0.5f)
        {
            one.transform.localScale -= new Vector3(0.03f, 0.03f, 0f);
            yield return new WaitForSeconds(0.05f);
        }
        Destroy(one);
        //one

        start.transform.position = new Vector3(540f, 810f, 0f);
        yield return new WaitForSeconds(0.7f);
        Destroy(start);
        //start
        Destroy(context);
        dontmoon.transform.position = new Vector3(0, -500, 0);
        gamestart = true;
    }
}