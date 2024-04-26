using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_script : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    void Start()
    {
        transform.Rotate(0,Random.Range(0,359),0);
        transform.position = new Vector3(transform.position.x,transform.position.y + Random.Range(-10f,-9f),transform.position.z);
        transform.localScale = new Vector3(4, 4, 4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
