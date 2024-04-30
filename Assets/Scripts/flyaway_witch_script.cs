using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyaway_witch_script : MonoBehaviour
{
    public Rigidbody fwrb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("speed", 2);
        Invoke("selfdestruct", 6);
    }

    public void speed()
    {
        fwrb.velocity = new Vector3(-10,4);
    }
    public void selfdestruct()
    {
        Destroy(gameObject);
    }
   
}
