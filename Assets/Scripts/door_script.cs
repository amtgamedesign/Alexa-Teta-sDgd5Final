using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class door_script : MonoBehaviour
{
    public FirstPersonController_Script player;
    public TextMeshProUGUI Instructions;
    public bool text;
    public Vector3 doorchange;

    public Vector3 doorrotate;
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 15)
        {
            if (text == false)
            {
                Instructions.text = "Press E";
            }
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.position = doorchange;
                    //new Vector3(-10.7700005f,12.3540001f,7.53000021f);
                transform.Rotate(doorrotate);
                text = true;
                Instructions.text = "";
            }
            
        }
        else
        {
            if (Vector3.Distance(player.transform.position, transform.position) > 16) 
            { Instructions.text = ""; }
        }
    }
}
