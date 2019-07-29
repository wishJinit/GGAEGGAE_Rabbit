using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_fail_rabbit : MonoBehaviour {
    public GameObject l_rabbit;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(l_rabbit);
       
     // transform.Translate(new Vector3(-1.0f, 0.0f, 0.0f) * (float)0.1f);
    }
}
