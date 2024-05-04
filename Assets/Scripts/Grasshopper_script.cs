using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grasshopper_script : MonoBehaviour
{
    public float Countdown;
    public float JumpTime;
    public int jumppower = 3;
    public Rigidbody grb;
 

    // Update is called once per frame
    void Update()
    {
        Countdown -= Time.deltaTime;
        Physics.gravity = new Vector3(0,-1f,0);
        if (Countdown <= 0)
        {
         
            grb.velocity = new Vector3(0,3);
            Countdown = JumpTime;
        }
    }
}
