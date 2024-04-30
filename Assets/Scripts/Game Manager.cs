using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI countdown;
    private float endtimer = 60;

    public GameObject[] animals;

    public GameObject[] princeprefabs;
    
    private float yspawn = 1.5f;

    public GameObject rock;

    public int number;
    
    // Start is called before the first frame update
    void Start()
    {
        updatetimer();
        
        //Spawn the animals
        //Quad 1
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,90f),yspawn,Random.Range(70f,154f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,90f),yspawn,Random.Range(70f,154f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,90f),yspawn,Random.Range(70f,154f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,90f),yspawn,Random.Range(70f,154f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,90f),yspawn,Random.Range(70f,154f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,90f),yspawn,Random.Range(70f,154f)), Quaternion.identity);
        Instantiate(rock,new Vector3(Random.Range(6f,90f),yspawn,Random.Range(70f,154f)), Quaternion.identity);
        Instantiate(rock,new Vector3(Random.Range(6f,90f),yspawn,Random.Range(70f,154f)), Quaternion.identity);
        
        //Quad 2
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-90f,-6f),yspawn,Random.Range(70f,132f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-90f,-6f),yspawn,Random.Range(70f,132f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-90f,-6f),yspawn,Random.Range(70f,132f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-90f,-6f),yspawn,Random.Range(70f,132f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-90f,-6f),yspawn,Random.Range(70f,132f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-90f,-6f),yspawn,Random.Range(70f,132f)), Quaternion.identity);
        Instantiate(rock,new Vector3(Random.Range(-90f,-6f),yspawn,Random.Range(70f,132f)), Quaternion.identity);
        Instantiate(rock,new Vector3(Random.Range(-90f,-6f),yspawn,Random.Range(70f,132f)), Quaternion.identity);

        //Quad 3
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-99f,-6f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-99f,-6f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-99f,-6f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-99f,-6f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-99f,-6f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(-99f,-6f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(rock,new Vector3(Random.Range(-99f,-6f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(rock,new Vector3(Random.Range(-99f,-6f),yspawn,Random.Range(12f,62f)), Quaternion.identity);

        //Quad 4
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,99f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,99f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,99f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,99f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,99f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(animals[UnityEngine.Random.Range(0, animals.Length )],new Vector3(Random.Range(6f,99f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(rock,new Vector3(Random.Range(6f,99f),yspawn,Random.Range(12f,62f)), Quaternion.identity);
        Instantiate(rock,new Vector3(Random.Range(6f,99f),yspawn,Random.Range(12f,62f)), Quaternion.identity);

        
        
        //Spawn the prince
        //This script uses a array to randomly pick from a select number of prefabs
        Instantiate(princeprefabs[UnityEngine.Random.Range(0, princeprefabs.Length )],new Vector3(Random.Range(-60f,45f),yspawn,Random.Range(20f,100f)), Quaternion.identity);

       
        
    }
    
    
    // Update is called once per frame
    void Update()
    {
        updatetimer();
        endtimer -= Time.deltaTime;
        
        if (endtimer <= 0)
        {
            SceneManager.LoadScene("Main Game");
        }
    }

    public void updatetimer()
    {
        countdown.text = "Time Left: " + endtimer.ToString("######.");
    }
    
}
