using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enchantedforest_script : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        body_script body = other.gameObject.GetComponent<body_script>();
        if (body != null)
        {
            SceneManager.LoadScene("Main Game");
        }
    }
    
}
