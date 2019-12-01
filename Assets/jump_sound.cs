using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_sound : MonoBehaviour
{
    public AudioSource jump;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            jump.Play();
    }
}
