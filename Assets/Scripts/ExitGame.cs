using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        if(Application.platform != RuntimePlatform.WebGLPlayer)
        {
            Application.Quit();
        }
        
    }
}
