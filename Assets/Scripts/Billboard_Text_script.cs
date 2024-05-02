using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard_Text_script : MonoBehaviour
{
    public bool Reverse;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(FirstPersonController_Script.player.transform);
        Vector3 rot = transform.rotation.eulerAngles;
        if (Reverse == true)
            transform.rotation = Quaternion.Euler(0,rot.y + 180,0);
        else
        {
            transform.rotation = Quaternion.Euler(0,rot.y,0);
        }

    }
}
