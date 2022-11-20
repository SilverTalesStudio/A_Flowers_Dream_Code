using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unmute : MonoBehaviour
{
    private void Update()
    {
        if(!GetComponent<AudioSource>().isPlaying)
            GetComponent<AudioSource>().mute = false;
        
    }
}
