using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beehive_script : MonoBehaviour
{
    public float Countdown;
 
    public float SpawnTime;
    
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
            Vector3 where = transform.position + new Vector3(Random.Range(-5,5), 4, transform.position.z + Random.Range(-5,5));
            Instantiate(SpawnedObject, where, Quaternion.identity);
            Countdown = SpawnTime;
        }
        
    }
}
