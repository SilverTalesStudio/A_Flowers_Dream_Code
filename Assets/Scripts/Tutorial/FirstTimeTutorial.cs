using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTimeTutorial : MonoBehaviour
{
    private static readonly string FirstTimeTuto = "FirstTimeTutorial";
    private int firstTimeInt;
    public GameObject Tutorial;
    public GameObject ButtonBack;
    // Start is called before the first frame update
    private void Start()
    {
        firstTimeInt = PlayerPrefs.GetInt(FirstTimeTuto);

        if(firstTimeInt == 0)
        {
            Tutorial.SetActive(true);
            ButtonBack.SetActive(false);
            PlayerPrefs.SetInt(FirstTimeTuto, -1);
        }
    }
}
