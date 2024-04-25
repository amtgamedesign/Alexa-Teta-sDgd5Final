using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FirstPersonController_Script : MonoBehaviour
{
    public Rigidbody RB;
    public float speed;
    public float extraboost;
    public float Mousespeed;
    public Camera Eyes;
    public Proj_script ProjectilePrefab;
    
    public float Health = 10;
    public float Healthmax = 10;
    public Transform Healthbar;
    
    public float speedboost = 10;
    public float speedboostmax = 10;
    public Transform speedboostbar;
    public float number = 10;
    
    public int animalcheck = 0;

 
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
 
    }

    public void Damage(float amt)
    {
        Health -= amt;
        float hperc = Health / Healthmax;
        Healthbar.localScale = new Vector3(hperc * 1,1,1);
    }
    
    public void Speedboostleft(float amt)
    {
        speedboost -= amt;
        float sbsbm = speedboost / speedboostmax;
        speedboostbar.localScale = new Vector3(sbsbm * 1,1,1);
        speed = 20;
    }
    
    public void Speedboostraise(float amt)
    {
        speedboost -= amt;
        float sbsbm = speedboost / speedboostmax;
        speedboostbar.localScale = new Vector3(sbsbm * 1,1,1);
        speed = 10;
    }
    
   
    
    // Update is called once per frame
    void Update()
    {
        
        //speed = 0;
        if (Health <= 0)
        {
            Health = Healthmax;
            Healthbar.localScale = new Vector3(1,1,1);

        }
        
        if (speedboost <= 10)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                speedboostbar.localScale = new Vector3(0,0,0);
            }
           
        }
        
        
        float xMouse = Input.GetAxis("Mouse X") * Mousespeed;
        transform.Rotate(0,xMouse,0);

        float yMouse = Input.GetAxis("Mouse Y") * Mousespeed;
        Eyes.transform.Rotate(-yMouse,0,0);
        
        if (Input.GetMouseButtonDown(0))
        {
            //Spawn a projectile right in front of my eyes
            Instantiate(ProjectilePrefab, Eyes.transform.position + Eyes.transform.forward, Eyes.transform.rotation);

            if (Physics.Raycast(Eyes.transform.position, Eyes.transform.forward, out RaycastHit hit, 25))
            {
                RB.AddForce(Eyes.transform.forward * 10, ForceMode.Impulse);
            }
        }
       
       // vel.y = RB.velocity.y;

        if (speed > 0)
        {
            Vector3 vel = Vector3.zero;
            
            if (Input.GetKey(KeyCode.W))
            {
                vel += transform.forward;
            }

            if (Input.GetKey(KeyCode.S))
            {
                vel -= transform.forward;
            }

            if (Input.GetKey(KeyCode.A))
            {
                vel -= transform.right;
            }

            if (Input.GetKey(KeyCode.D))
            {
                vel += transform.right;
            }

            
            if (Input.GetKeyDown(KeyCode.P))
            {
                Damage(-1);
            }
            
            vel = vel.normalized * speed;
            RB.velocity = vel;
            
            
            if (number <= 0)
            {
                speedboostbar.localScale = new Vector3(0,0,0);;
                speed = 1;
                Speedboostraise(-Time.deltaTime);
                number += Time.deltaTime;
             
            }
            if (Input.GetKey(KeyCode.Q) && speed > 0)
            {
                Speedboostleft(Time.deltaTime);
                number -= Time.deltaTime;
                return;
            }
           // speed = extraboost;
            if (number < 10)
            {
                Speedboostraise(-Time.deltaTime);
                number += Time.deltaTime;
            }
            if (number > 10)
            {
                number = 10;
            }

          
                     
        }
        
        
    }

    public void OnCollisionEnter(Collision other)
    {
        // trial_script trail = other.gameObject.GetComponent<trial_script>();
        // if ( trail != null)
        // {
        //     Damage(.2f);
        // }
    }
}