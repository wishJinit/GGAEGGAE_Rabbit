using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fail_screen : MonoBehaviour {

    public float stoppoint_y, speed;
        
    // Update is called once per frame
    void Update ()
    {
        if(transform.position.y<=stoppoint_y)
            transform.Translate(new Vector3(0f, speed, 0));
    }
}
