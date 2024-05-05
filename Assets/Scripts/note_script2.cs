using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_script2 : MonoBehaviour
{
    public GameObject thenote;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { 
           thenote.SetActive(false); 
           door_script.notegone = true;
        }
    }
}
