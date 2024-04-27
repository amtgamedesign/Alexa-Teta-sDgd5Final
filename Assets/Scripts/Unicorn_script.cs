using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicorn_script : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(4,4);
        Invoke("selfdestruct",15);
    }

    public void selfdestruct()
    {
        Destroy(gameObject);
    }
}
