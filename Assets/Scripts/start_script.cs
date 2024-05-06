using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Loadscene();
        }
    }

    public void Loadscene()
    {
        SceneManager.LoadScene("Flyer Scene");
    }
}
