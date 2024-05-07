using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiognome_script : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip Sound;

    public void Start()
    {
        AS.PlayOneShot(Sound);
        Invoke("selfdestruct", 5);
    }

    public void selfdestruct()
    {
        Destroy(gameObject);
    }
}
