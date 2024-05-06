using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("selfdestruct", 2);
    }

    public void selfdestruct()
    {
        Destroy(gameObject);
    }
}
