using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy2_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("selfdestruct",4f);
    }

    void selfdestruct()
    {
        Destroy(gameObject);
    }
}
