using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_room_script : MonoBehaviour
{
    public CutscenePlayer player;

    public TextMeshPro instr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 20)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Witch scene");
            }
            instr.text = "Press E to Go outside";
        }
        else
        {
            if (Vector3.Distance(player.transform.position, transform.position) > 23)
            {
                instr.text = "";
            }
        }
    }
}
