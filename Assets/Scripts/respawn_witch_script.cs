using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class respawn_witch_script : MonoBehaviour
{
    public bool Reverse;
    public float[] spawningzlocations;
    public int health = 10;
    public GameObject audiognome1, audiognome2;


    public void Start()
    {
      Bounce_wall_script.wall = FindObjectOfType<Bounce_wall_script>();
      Instantiate(audiognome1, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = new Vector3(0,-15f,0);
        transform.LookAt(Bounce_wall_script.wall.transform);
        Vector3 rot = transform.rotation.eulerAngles;
        if (Reverse == true)
            transform.rotation = Quaternion.Euler(0,rot.y + 180,0);
        else
        {
            transform.rotation = Quaternion.Euler(0,rot.y,0);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            
        }
        
        
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Bounce_wall_script.wall.transform.position, Random.Range(.3f, .4f));
    }

    public void OnCollisionEnter(Collision other)
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Bounce_wall_script bwall = other.gameObject.GetComponent<Bounce_wall_script>();
        if ( bwall != null)
        {
            transform.position = new Vector3(Random.Range(-99,90),2f, Random.Range(12,154));
            //transform.position = Random.insideUnitSphere;
            //Random.Range(0,spawningzlocations.Length)
            Instantiate(audiognome1, transform.position, Quaternion.identity);
        }
        
        Animal_script ani = other.gameObject.GetComponent<Animal_script>();
        if (ani != null)
        {
            other.transform.position = new Vector3(Random.Range(-60f,45f), 1.5f,Random.Range(20f,100f));
        }
        
        Proj_script proj = other.gameObject.GetComponent<Proj_script>();
        if (proj != null)
        {
            Destroy(other.gameObject);
            Instantiate(audiognome2, transform.position, Quaternion.identity);
        }
        
    }
}
