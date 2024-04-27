using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x,5,transform.position.z);
        transform.Rotate(0,0,-45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
