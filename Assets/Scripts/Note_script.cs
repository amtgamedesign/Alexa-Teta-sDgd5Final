using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Note_script : MonoBehaviour
{
    public CutscenePlayer player;
    public TextMeshProUGUI Instructions;
    public bool text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 15)
        {
            if (text == false)
            {
                Instructions.text = "Press E to read note";
            }
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                text = true;
                Instructions.text = "";
                door_script.notegone = true;
                Destroy(gameObject);
            }
            
        }
        else
        {
            if (Vector3.Distance(player.transform.position, transform.position) > 16) 
            { Instructions.text = ""; }
        }
    }
}
