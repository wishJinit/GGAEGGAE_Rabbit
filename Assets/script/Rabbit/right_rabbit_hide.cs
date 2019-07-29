using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_rabbit_hide : MonoBehaviour {

    public moonclick_count rabbit_R_hidecnt;

    // Use this for initialization
    void Start()
    {
        rabbit_R_hidecnt = GameObject.Find("Moon").GetComponent<moonclick_count>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rabbit_R_hidecnt.count > 5)//이거 바꿔야함
        {
            transform.Translate(new Vector3(1.0f, 0.0f, 0.0f) * (float)0.5f);
        }
    }

   
}
