using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyaway_witch_script : MonoBehaviour
{
    public Rigidbody fwrb;

    public GameObject laugh;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("speed", 1.2f);
        Invoke("selfdestruct", 3.2f);
        Instantiate(laugh,transform.position,Quaternion.identity);
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
