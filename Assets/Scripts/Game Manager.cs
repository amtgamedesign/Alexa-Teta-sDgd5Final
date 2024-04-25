using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI countdown;
    public float endtimer = 60;

    public GameObject[] animals;

    public GameObject[] princeprefabs;

    private float yspawn = 1.5f;

    public int number;
    
    // Start is called before the first frame update
    void Start()
    {
        updatetimer();
        
        //Spawn the animals
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);
        
        
        
        //Spawn the prince
        //This script uses a array to randomly pick from a select number of prefabs
        Instantiate(princeprefabs[UnityEngine.Random.Range(0, princeprefabs.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);

    }
    
    
    // Update is called once per frame
    void Update()
    {
        updatetimer();
        endtimer -= Time.deltaTime;
    }

    public void updatetimer()
    {
        countdown.text = "Time Left: " + endtimer.ToString("######.");
    }
    
}
