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

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if (f.name != "FlowerBase")
                f.GetComponent<DragAndDrop>().enableClick = false;
        }
    }

    public void DeactivateFlowersBook()
    {
        book.SetActive(false);
        Time.timeScale = 1;

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if (f.name != "FlowerBase")
                f.GetComponent<DragAndDrop>().enableClick = true;
        }
    }
}
