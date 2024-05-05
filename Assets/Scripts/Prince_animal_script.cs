using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Prince_animal_script : MonoBehaviour
{
    public TextMeshPro Instructions;
    public FirstPersonController_Script player;
    public GameObject princelyprefab;
    public bool reverse, textbool;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FirstPersonController_Script>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 10)
        {
            if (textbool == true)
            {
                Instructions.text = "Press E to Kiss";
            }    

            if (textbool == false)
            {
                Instructions.text = "";
            }     
            
            transform.LookAt(FirstPersonController_Script.player.transform);
            Vector3 rot = transform.rotation.eulerAngles;
            if (reverse == true)
                transform.rotation = Quaternion.Euler(0,rot.y + 180,0);
            else
            {
                transform.rotation = Quaternion.Euler(0,rot.y,0);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(princelyprefab, transform.position, Quaternion.identity);
                textbool = true;
                Destroy(gameObject);   
            }
        }
        else
        {
            if (Vector3.Distance(player.transform.position, transform.position) > 17)
            {
                Instructions.text = "";
            }
        }
    }
}
