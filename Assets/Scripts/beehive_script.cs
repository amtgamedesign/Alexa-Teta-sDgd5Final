using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beehive_script : MonoBehaviour
{
    public float Countdown;
 
    public float SpawnTime;
    public int hivehealth = 3;
    public GameObject SpawnedObject;


    void Start()
    {
        transform.position = new Vector3(transform.position.x,3,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
   
        
        Countdown -= Time.deltaTime;
        //If Countdown hits 0, that means it's time to spawn the new object
        if (Countdown <= 0)
        {
            
            Instantiate(SpawnedObject, new Vector3(transform.position.x,transform.position.y+3,transform.position.z), Quaternion.identity);
            Countdown = SpawnTime;
        }

        if (hivehealth <= 0)
        {
            Destroy(gameObject);
        }
        
    }
    
    public void Damage(int amt)
    {
        hivehealth -= amt;
   

    }

    public void OnCollisionEnter(Collision other)
    {
        Proj_script proj = other.gameObject.GetComponent<Proj_script>();
        if (proj != null)
        {
            Damage(1);
        }
    }
}
