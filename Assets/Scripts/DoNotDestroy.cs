using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("MenuMusic");
        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "VisualNovel" || SceneManager.GetActiveScene().name == "VisualNovel")
        {
            Destroy(this.gameObject);
        }
    }
}
