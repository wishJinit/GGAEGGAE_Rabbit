using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_broken_moon : MonoBehaviour {
    int flag;
    float a;
	// Use this for initialization
	void Start () {
        a = 0.0f;
        flag = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (flag == 0)
        {

            a += 0.5f;
            transform.Rotate(0, 0, -a);

        }
        if (a == 7)
        {
            flag = 1;
        }
       
       

		
	}
}
