using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class door_script : MonoBehaviour
{
    public CutscenePlayer player;
    public TextMeshPro Instructions;
    public TextMeshProUGUI text1;
    public bool text;
    public Vector3 doorchange;
    public Vector3 doorrotate;
    public static bool notegone = false;
    public bool textbool;

    public void updatetext()
    {
        text1.text = "";
    }
    
    // Update is called once per frame
    void Update()
    {
        if (notegone == true)
        {
            if (Vector3.Distance(player.transform.position, transform.position) < 20)
            {
                if (text == false)
                {
                    textbool = true;
                    if (textbool == true)
                    {
                        Instructions.text = "Press E to open door";
                    }

                    if (textbool == false)
                    {
                        Instructions.text = "";
                    }

                  text1.text = "\"I must save my love!\"";
                  
                  Invoke("updatetext",4);
                }

                if (Input.GetKeyDown(KeyCode.E))
                {
                    transform.position = doorchange;
                    //new Vector3(-10.7700005f,12.3540001f,7.53000021f);
                    transform.Rotate(doorrotate);
                    text = true;
                    Instructions.text = "";
                    Destroy(Instructions);
                }

            }
            else
            {
                if (Vector3.Distance(player.transform.position, transform.position) > 23)
                {
                    Instructions.text = "";
                }
            }
        }
    }
}
