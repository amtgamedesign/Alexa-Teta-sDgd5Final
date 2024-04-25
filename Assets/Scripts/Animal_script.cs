using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Animal_script : MonoBehaviour
{
   // public TextMeshProUGUI Instructions;
    public FirstPersonController_Script player;
    public Animal_script Animals;
    public Material Wrongchoice;
    public MeshRenderer mr;
    public Rigidbody rb;
    public GameObject spiders;
    public Material startcolor;
    public int spawnspiders;
    public Vector3 speed, checker;
    private float number1 = 5.5f,number2 = 6.5f;
    public bool checkedanimal = false;
   
 
    //public Material[] randomcolor;
    //public List<Material> Colors;

    //Change movement!
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(Random.Range(Random.Range(-number2,-number1),Random.Range(number1,number2)),0,Random.Range(Random.Range(-number2,-number1),Random.Range(number1,number2)));
        player = FindObjectOfType<FirstPersonController_Script>();
        //Instructions = FindObjectOfType<TextMeshProUGUI>();
        speed = rb.velocity;
       // mr.material.color = new Color(Random.Range(0.0f,1.0f),Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f));

    }

    // Update is called once per frame
    void Update()
    {
        checker = rb.velocity;
       
        if (Vector3.Distance(player.transform.position, transform.position) < 16)
        {
            rb.velocity = new Vector3(0, 0,0);
          //  Instructions.text = "";
            
            if (Input.GetKeyDown(KeyCode.E) && checkedanimal == false)
            {
                mr.material = Wrongchoice;
                spawnspiders = Random.Range(1,5);
                player.Damage(2);
              //  Instructions.text = "";
                checkedanimal = true;
                
                if (spawnspiders == 1)
                {
                    Instantiate(spiders, transform.position, Quaternion.identity);
                    Destroy(gameObject);
                }
            }
            
        }
        
            if (Vector3.Distance(player.transform.position, transform.position) > 18)
            {
             //   Instructions.text = "";
                if (checkedanimal == false)
                {
                    checker = rb.velocity;
                }
                //rb.velocity = speed;
            }
        
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WallH"))
        {
            Vector3 vel = rb.velocity;
            vel.x *= -1;
            vel.z *= -1;
            rb.velocity = vel;
          
        }
        
        if (other.gameObject.CompareTag("WallV"))
        {
            Vector3 vel = rb.velocity;
            vel.x *= -1;
            vel.z *= -1;
            rb.velocity = vel;
          
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        //Animal_script ani = other.gameObject.GetComponent<Animal_script>();
       
        
    }
}
