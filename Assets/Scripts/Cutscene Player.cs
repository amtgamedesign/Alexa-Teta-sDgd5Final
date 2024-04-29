using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutscenePlayer : MonoBehaviour
{
    public Camera Eyes;
    public Rigidbody RB;
    public float Mousespeed = 3;
    public float WalkSpeed = 10;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    {
        // float xMouse = Input.GetAxis("Mouse X") * Mousespeed;
        // transform.Rotate(0,xMouse,0);

        float xMouse = Input.GetAxis("Mouse X") * Mousespeed;
        transform.Rotate(0,xMouse,0);
        
        float yMouse = Input.GetAxis("Mouse Y") * Mousespeed;
        Eyes.transform.Rotate(-yMouse,0,0);

        if (WalkSpeed > 0)
        {
            Vector3 move = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
                move += transform.forward;
            if (Input.GetKey(KeyCode.S))
                move -= transform.forward;
            if (Input.GetKey(KeyCode.A))
                move -= transform.right;
            if (Input.GetKey(KeyCode.D))
                move += transform.right;
            move = move.normalized * WalkSpeed;
            RB.velocity = move;
        }

    }
}
