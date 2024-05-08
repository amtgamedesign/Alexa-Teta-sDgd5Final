using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class board_script : MonoBehaviour
{
    public cutsceneplayer2 player;
    public int boardhealth = 1;
    public TextMeshPro textint;

    public static bool rockgone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boardhealth <= 0)
        {
            Destroy(gameObject);
        }
        
        if (Vector3.Distance(player.transform.position, transform.position) < 15)
        {
            if (rockgone == false)
            {
                textint.text = "Grab rocks to destroy Stuctures and Enemies";
            }

            if (rockgone == true)
            {
                textint.text = "Use the Left Mouse Button to throw rocks";
            }
            
        }

        if (Vector3.Distance(player.transform.position, transform.position) > 16)
        {
            textint.text = "";
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        Proj_script proj = other.gameObject.GetComponent<Proj_script>();
        if ( proj != null)
        {
            boardhealth--;
            Destroy(other.gameObject);
        }
    }
}
