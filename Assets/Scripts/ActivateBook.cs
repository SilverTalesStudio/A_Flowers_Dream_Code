using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBook : MonoBehaviour
{
    public GameObject book;


    public void ActivateFlowersBook()
    {
        book.SetActive(true);
       

        Time.timeScale = 0;
    }

    public void DeactivateFlowersBook()
    {
        book.SetActive(false);
        Time.timeScale = 1;
    }
}
