using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyaway_witch_script : MonoBehaviour
{
    public Rigidbody fwrb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("speed", 1);
        Invoke("selfdestruct", 3.5f);
    }

    public void speed()
    {
        fwrb.velocity = new Vector3(-18,10);
    }
    public void selfdestruct()
    {
        Destroy(gameObject);
    }
   
}
