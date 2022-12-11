using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("MenuMusic");
        if (tag == "MenuMusic" && musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if(tag == "MenuMusic" && SceneManager.GetActiveScene().name == "VisualNovel")
        {
            Destroy(this.gameObject);
        }
    }
}
