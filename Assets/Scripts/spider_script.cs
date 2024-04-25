using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spider_script : MonoBehaviour
{
    public body_script body;
    public bool startchase = false;
    
    // Start is called before the first frame update
    void Start()
    {
        body = FindObjectOfType<body_script>();
        Invoke("Chase",1.2f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Add something so that the spiders do not come after you super fast 

        if (startchase == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, body.transform.position, Random.Range(.01f, .2f));
        }
    }

    public void Chase()
    {
        startchase = true;
    }
    
}
