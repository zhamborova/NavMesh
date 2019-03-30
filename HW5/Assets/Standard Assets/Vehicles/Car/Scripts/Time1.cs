using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time1 : MonoBehaviour
{
    public float t;
    public string name;
    public bool finished = false;


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            t = Time.realtimeSinceStartup;
            finished = true;
        }
    }
}
