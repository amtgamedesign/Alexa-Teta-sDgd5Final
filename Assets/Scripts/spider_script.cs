using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spider_script : MonoBehaviour
{
    public body_script body;
    public bool startchase = false;
    public int health;
    public Material redcolor, coalcolor;
    public MeshRenderer MR;
    public GameObject audiognome;
    
    // Start is called before the first frame update
    void Start()
    {
        body = FindObjectOfType<body_script>();
        Invoke("Chase",.2f);
    }

    // Update is called once per frame
    public void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            FirstPersonController_Script.enemies++;
        }
    }

    void FixedUpdate()
    {
        //Add something so that the spiders do not come after you super fast 
        MR.material = coalcolor;
        if (startchase == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, body.transform.position, Random.Range(.1f, .2f));
        }
    }
    public void Damage(int amt)
    {
       health -= amt;
       MR.material = redcolor;
    }
    public void Chase()
    {
        startchase = true;
    }

    public void OnCollisionEnter(Collision other)
    {
        Proj_script proj = other.gameObject.GetComponent<Proj_script>();
        if (proj != null)
        {
            Damage(1);
            Instantiate(audiognome, transform.position, Quaternion.identity);
        }

    }
}
