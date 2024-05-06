using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text_script : MonoBehaviour
{
    public TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "";
        Invoke("nexttext", 1);
        Invoke("selfdestruct", 6);
    }
    
    void nexttext()
    {
        text.text = "Follow the Witch" +
                    "   " +
                    "Hold Q to Sprint";
    }
    
    void selfdestruct()
    {
        Destroy(gameObject);
    }
}
