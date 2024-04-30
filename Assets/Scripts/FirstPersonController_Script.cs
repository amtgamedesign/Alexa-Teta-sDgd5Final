
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


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
    public float number = 5, total = 5, stunned = 0, rocktotal = 5;
    public TextMeshProUGUI rocktext;
    
    public static int animalcheck = 0;


 
    
    
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
    
    public void Updateanimalcount(int amt)
    {
        animalcheck += amt;
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
    
    public void updaterocks()
    {
        rocktext.text =  rocktotal.ToString("") + " Rocks";
    }

    public void rocks(int amt)
    {
        rocktotal += amt;
    }

    
    // Update is called once per frame
    void Update()
    {
        //speed = 0
        updaterocks();
        
        if (Health <= 0)
        {
            SceneManager.LoadScene("Main Game");
            Health = Healthmax;
            Healthbar.localScale = new Vector3(1,1,1);
        }
        
        
        float xMouse = Input.GetAxis("Mouse X") * Mousespeed;
        transform.Rotate(0,xMouse,0);

        float yMouse = Input.GetAxis("Mouse Y") * Mousespeed;
        Eyes.transform.Rotate(-yMouse,0,0);
        
        if (Input.GetMouseButtonDown(0) && rocktotal > 0)
        {
            //Spawn a projectile right in front of my eyes
            Instantiate(ProjectilePrefab, Eyes.transform.position + Eyes.transform.forward, Eyes.transform.rotation);
            rocktotal--;

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
                stunned = 3f;
                speedboostbar.localScale = new Vector3(0,0,0);;
                Speedboostraise(-Time.deltaTime);
                number += Time.deltaTime;
            }
            if (stunned > 0)
            {
                speed = 1;
                stunned -= Time.deltaTime;
                return;
            }
            if (speedboost <= 0)
            {
                if (Input.GetKey(KeyCode.Q))
                {
                    speedboostbar.localScale = new Vector3(0,0,0);
                }
           
            }
            if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.D)) 
            {
                Speedboostleft(Time.deltaTime);
                number -= Time.deltaTime;
                return;
            }
            if (number < total)
            {
                Speedboostraise(-Time.deltaTime);
                number += Time.deltaTime;
            }
            if (number > total)
            {
                number = total;
            }
            
        }
        
        
    }

    public void OnCollisionEnter(Collision other)
    {
        bee_script bee = other.gameObject.GetComponent<bee_script>();
        if ( bee != null)
        {
            Damage(1);
            other.rigidbody.AddForce(transform.forward * 12, ForceMode.Impulse);
        }
        
        spider_script spider = other.gameObject.GetComponent<spider_script>();
        if ( spider != null)
        {
            Damage(1);
            other.rigidbody.AddForce(transform.forward * 10, ForceMode.Impulse);
        }
        
        heart_script heart = other.gameObject.GetComponent<heart_script>();
        if ( heart != null)
        {
            Damage(-1);
            Destroy(other.gameObject);
        }
        
        rock_script rock = other.gameObject.GetComponent<rock_script>();
        if ( rock != null)
        {
            rocks(Random.Range(1,5));
            Destroy(other.gameObject);
        }
    }
    
}
