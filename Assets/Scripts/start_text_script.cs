using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class start_text_script : MonoBehaviour
{
    public TextMeshProUGUI text1, text2;
    // Start is called before the first frame update
    void Start()
    {
      
        text2.text = "";
        Invoke("text0update", 1.2f);
        Invoke("text2update", 7f);
        Invoke("text1update", 3.5f);
    }

    public void text0update()
    {
        text1.text = "\"Oh a letter is on my door\"";
    }

    public void text1update()
    {
        text1.text = "";
        text2.text = "Use \"WSAD\" to Move";
    }
    
    public void text2update()
    {
        text2.text = "";
    }
    
    
}
