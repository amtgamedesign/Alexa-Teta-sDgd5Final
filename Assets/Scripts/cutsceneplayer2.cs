using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cutsceneplayer2 : MonoBehaviour
{
    public Camera Eyes;
    public Rigidbody RB;
    public float MouseSensitivity = 3;
    public float WalkSpeed = 10;
    public GameObject ProjectilePrefab;
    public float speedboost = 10, speed;
    public float speedboostmax = 10;
    public Transform speedboostbar;
    public float number = 5, total = 5, stunned = 0, rocktotal;
    public TextMeshProUGUI rocktext;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Speedboostleft(float amt)
    {
        speedboost -= amt;
        float sbsbm = speedboost / speedboostmax;
        speedboostbar.localScale = new Vector3(sbsbm * 1,1,1);
        WalkSpeed = 20;
    }
    
    public void Speedboostraise(float amt)
    {
        speedboost -= amt;
        float sbsbm = speedboost / speedboostmax;
        speedboostbar.localScale = new Vector3(sbsbm * 1,1,1);
        WalkSpeed = 10;
    }
    
    public void updaterocks()
    {
        rocktext.text =  rocktotal.ToString("") + " Rocks";
    }

    
    public void OnCollisionEnter(Collision other)
    {
        rock_script rock = other.gameObject.GetComponent<rock_script>();
        if ( rock != null)
        {
            rocks(6);
            Destroy(other.gameObject);
            board_script.rockgone = true;
        }
    }
    public void rocks(int amt)
    {
        rocktotal += amt;
        
    }
    

    void Update()
    {
        updaterocks();
      
        float xRot = Input.GetAxis("Mouse X") * MouseSensitivity;
        float yRot = -Input.GetAxis("Mouse Y") * MouseSensitivity;
        transform.Rotate(0,xRot,0);
        Vector3 eRot = Eyes.transform.localRotation.eulerAngles;
        eRot.x += yRot;
        if (eRot.x < -180) eRot.x += 360;
        if (eRot.x > 180) eRot.x -= 360;
        eRot = new Vector3(Mathf.Clamp(eRot.x, -90, 90),0,0);
        Eyes.transform.localRotation = Quaternion.Euler(eRot);
   

        if (WalkSpeed > 0)
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
                move += transform.forward;
            if (Input.GetKey(KeyCode.S))
                move -= transform.forward;
            if (Input.GetKey(KeyCode.A))
                move -= transform.right;
            if (Input.GetKey(KeyCode.D))
                move += transform.right;
            move = move.normalized * WalkSpeed;
            RB.velocity = move;
        }
        
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
        
        if (number <= 0)
        {
            stunned = 3f;
            speedboostbar.localScale = new Vector3(0,0,0);;
            Speedboostraise(-Time.deltaTime);
            number += Time.deltaTime;
        }
        if (stunned > 0)
        {
            WalkSpeed = 1;
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
