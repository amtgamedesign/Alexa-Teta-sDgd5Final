using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proj_script : MonoBehaviour
{
    public Rigidbody RB;

    //How fast do I fly?
    public float Speed = 30;
    public GameObject audiognome;
    
    //How hard do I knockback things I hit?
    public float Knockback = 10;

    void Start()
    {
        //When I spawn, I fly straight forwards at my Speed
        RB.velocity = transform.forward * Speed;
        Invoke("Selfdestruct", 5);
        

    }

    public void OnCollisionEnter(Collision other)
    {
        //If I hit something with a rigidbody. . .
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            //I push them in the direction I'm flying with a power equal to my Knockback stat
            //rb.AddForce(RB.velocity.normalized * Knockback, ForceMode.Impulse);
        }

       
        bee_script bee = other.gameObject.GetComponent<bee_script>();
        if (bee != null)
        {
            Destroy(other.gameObject);
            Instantiate(audiognome, transform.position, Quaternion.identity);
        }
        
        

        //If I hit anything, I despawn
        Destroy(gameObject);
    }

    public void Selfdestruct()
    {
        Destroy(gameObject);
    }
}


