using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bee_script : MonoBehaviour
{
    public body_script body;
   
    
    // Start is called before the first frame update
    void Start()
    {
     //transform.position = new Vector3(transform.position.x,transform.position.y + 5,transform.position.z);
     body = FindObjectOfType<body_script>();
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  Add something so that the spiders do not come after you super fast 
        transform.position = Vector3.MoveTowards(transform.position,
            new Vector3(body.transform.position.x, body.transform.position.y + Random.Range(4.2f,5.2f) ,body.transform.position.z), Random.Range(.1f, .2f));
         
    }
    
}
