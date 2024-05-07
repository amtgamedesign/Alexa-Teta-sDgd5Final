using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Prince_animal_script : MonoBehaviour
{
    public TextMeshPro Instructions;
    public FirstPersonController_Script player;
    public GameObject princelyprefab, audiognome;
    public bool reverse, textbool;
    private float countdown = 20, soundtime = 20;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FirstPersonController_Script>();

    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Instantiate(audiognome, transform.position, Quaternion.identity);
            countdown = soundtime;
        }
        
        if (Vector3.Distance(player.transform.position, transform.position) < 10)
        {
         
            
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
            
            if (textbool == true)
            {
                Instructions.text = "Press E to Kiss";
            }

            if (textbool == false)
            {
                Instructions.text = "";
            } 
        }
        else
        {
            if (Vector3.Distance(player.transform.position, transform.position) > 12)
            {
                Instructions.text = "";
            }
        }
    }
}
