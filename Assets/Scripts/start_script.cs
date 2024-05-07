using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kiss;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(kiss, transform.position, Quaternion.identity);
        Invoke("Loadscene", 1);
    }

    public void Loadscene()
    {
        SceneManager.LoadScene("Flyer Scene");
    }
}
