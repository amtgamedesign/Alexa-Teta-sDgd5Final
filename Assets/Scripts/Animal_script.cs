using System;
using System.Collections;
using System.Collections.Generic;
using Mono.Reflection;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Animal_script : MonoBehaviour
{
   // public TextMeshProUGUI Instructions;
   // public FirstPersonController_Script player;
    public Animal_script Animals;
    public MeshRenderer mr;
    public GameObject spiders, unicorn, bees, heart, tinyhousepf, witch, grasshopper, kiss;
    public int spawnthings;
    public bool checkedanimal = false, Reverse, textbool = true;
    public static bool spawnunicorn = false, spawnwitch = false;
    public TextMeshPro Instructions;
 
 
    //public Material[] randomcolor;
    //public List<Material> Colors;

    // Start is called before the first frame update
    void Start()
    {
       // rb.velocity = new Vector3(Random.Range(Random.Range(-number2,-number1),Random.Range(number1,number2)),0,Random.Range(Random.Range(-number2,-number1),Random.Range(number1,number2)));
        FirstPersonController_Script.player = FindObjectOfType<FirstPersonController_Script>();
        transform.Rotate(0,Random.Range(0,359),0);
        spawnthings = Random.Range(1,12);
      
    }

    // Update is called once per frame
    void Update()
    {
        //checker = rb.velocity;
       
        if (Vector3.Distance(FirstPersonController_Script.player.transform.position, transform.position) < 10)
        {
           // rb.velocity = new Vector3(0, 0,0);
           transform.LookAt(FirstPersonController_Script.player.transform);
           Vector3 rot = transform.rotation.eulerAngles;
           if (Reverse == true)
               transform.rotation = Quaternion.Euler(0,rot.y + 180,0);
           else
           {
               transform.rotation = Quaternion.Euler(0,rot.y,0);
           }
            
            if (Input.GetKeyDown(KeyCode.E) && checkedanimal == false)
            {
                FirstPersonController_Script.player.Updateanimalcount(1);
                checkedanimal = true;
                textbool = false;
               kiss.SetActive(true);
                
                if (spawnthings == 3)
                {
                    Instantiate(spiders, transform.position, Quaternion.identity);
                    Destroy(gameObject);
                }

                if (spawnthings == 8 && spawnunicorn == false)
                {
                    Instantiate(unicorn, transform.position, Quaternion.identity);
                    Destroy(gameObject);
                    spawnunicorn = true;
                }

                if (spawnthings == 6)
                {
                    Instantiate(bees,transform.position, Quaternion.identity);
                    Destroy(gameObject);
                }

                if (spawnthings == 10 || spawnthings == 2)
                {
                    Instantiate(heart, transform.position, Quaternion.identity);
                    Destroy(gameObject);
                }
                
                if (spawnthings == 5)
                {
                    Instantiate(tinyhousepf, new Vector3(transform.position.x,transform.position.y + 0.5f,transform.position.z), Quaternion.identity);
                    Destroy(gameObject);
                }

                //Possibly have a fight with the witch
                if (spawnthings == 1 && spawnwitch == false)
                {
                    spawnwitch = true;
                  //  Instantiate(witch, new Vector3(transform.position.x,transform.position.y + 0.5f,transform.position.z), Quaternion.identity);
                }
                
                if (spawnthings == 11)
                {
                    spawnwitch = true;
                    Instantiate(grasshopper,transform.position, Quaternion.identity);
                    Destroy(gameObject);
                }

                if (spawnthings == 8 && spawnunicorn == true)
                {
//Instantiate(,transform.position, Quaternion.identity);
                }
          
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
        
            if (Vector3.Distance(FirstPersonController_Script.player.transform.position, transform.position) > 17)
            {
            Instructions.text = "";
            }
        
        
    }
    

    public void OnCollisionEnter(Collision other)
    {
        Animal_script ani = other.gameObject.GetComponent<Animal_script>();
        if (ani != null)
        {
            transform.position = new Vector3(Random.Range(-60f,45f), 1.5f,Random.Range(20f,100f));
        }
        
        rock_script rock = other.gameObject.GetComponent<rock_script>();
        if (rock != null)
        {
            other.transform.position = new Vector3(Random.Range(-60f,45f), 1.5f,Random.Range(20f,100f));
        }
        
    }
}
