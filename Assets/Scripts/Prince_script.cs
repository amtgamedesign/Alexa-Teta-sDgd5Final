using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prince_script : MonoBehaviour
{
    public GameObject audiognome;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(audiognome, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("win",3);
    }
    
    public void win()
    {
        SceneManager.LoadScene("Ending");
    }
    
}
