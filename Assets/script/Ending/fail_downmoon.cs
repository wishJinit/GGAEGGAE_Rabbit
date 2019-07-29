using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fail_downmoon : MonoBehaviour {
	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {    
       
            transform.Translate(new Vector3(2.0f, (float)-0.3f, 5) * 7);
	
	}
}
