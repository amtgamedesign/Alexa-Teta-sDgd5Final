using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text_script : MonoBehaviour
{
    public TextMeshProUGUI textstop;
    public TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        textstop.text = "";
        text.text = "";
        Invoke("firsttext", .2f);
        Invoke("nexttext", 2f);
        Invoke("selfdestruct", 6);
    }

    void firsttext()
    {
        textstop.text = "\"COME BACK WITCH!\"";
    }
    void nexttext()
    {
        text.text = "Follow the Witch" +
                    "   " +
                    "Hold Q to Sprint";
        textstop.text = "";
    }
    
    void selfdestruct()
    {
        Destroy(gameObject);
    }
}
