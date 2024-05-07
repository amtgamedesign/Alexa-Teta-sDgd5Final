using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stats_script : MonoBehaviour
{
    public TextMeshProUGUI time, animalkissed, enemiesdefeated;
        
        
    // Start is called before the first frame update
    void Start()
    {
        time.text = "Found Prince in: " + GameManager.endtimer.ToString("####.##") + " seconds";
        animalkissed.text = "Animals Kissed: " + FirstPersonController_Script.animalcheck;
        enemiesdefeated.text = "Enemies Defeated: " + FirstPersonController_Script.enemies;
    }
    
}
