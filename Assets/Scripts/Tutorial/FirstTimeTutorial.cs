using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTimeTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("FirstTimeTutorial"))
        {
            GameObject.FindGameObjectWithTag("Tutorial").SetActive(true);
            PlayerPrefs.SetInt("FirstTimeTutorial", 0);
            PlayerPrefs.Save();
        }

    }
}
