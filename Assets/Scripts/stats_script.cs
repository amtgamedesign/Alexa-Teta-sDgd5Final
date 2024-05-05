using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stats_script : MonoBehaviour
{
    public TextMeshProUGUI time, animalkissed;
        
        
    // Start is called before the first frame update
    void Start()
    {
        time.text = "Found Prince in: " + GameManager.endtimer.ToString("####.##");
        animalkissed.text = "Animals Kissed: " + FirstPersonController_Script.animalcheck;
    }
    
}
