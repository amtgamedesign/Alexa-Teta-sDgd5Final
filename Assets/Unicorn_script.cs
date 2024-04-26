using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicorn_script : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(3,3);
        Invoke("selfdestruct",10);
    }

    public void selfdestruct()
    {
        Destroy(gameObject);
    }
}
