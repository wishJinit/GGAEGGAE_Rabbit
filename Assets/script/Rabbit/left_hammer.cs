using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_hammer : MonoBehaviour
{
    // public GameObject moon;
    public moonclick_count cnt;

    void Start()
    {
        cnt = GameObject.Find("Moon").GetComponent<moonclick_count>();
    }

    public void l_move()
    {
         if (cnt.count % 2 == 0)
         {                
             transform.Rotate(0, 0, 80);
         }
         else
         {               
            transform.Rotate(0, 0, -80);
         }
    }
}

