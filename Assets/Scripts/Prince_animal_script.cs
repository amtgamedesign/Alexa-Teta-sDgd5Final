using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Prince_animal_script : MonoBehaviour
{
    public TextMeshProUGUI Instructions;
    public FirstPersonController_Script player;
    public GameObject princelyprefab;
    
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FirstPersonController_Script>();
        Instructions = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 15)
        {
            Instructions.text = "Press E to Kiss";
            if (Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(princelyprefab, transform.position, Quaternion.identity);
                Destroy(gameObject);   
            }
        }
        else
        {
            if (Vector3.Distance(player.transform.position, transform.position) > 16)
            {
                Instructions.text = "";
            }
        }
    }
}
