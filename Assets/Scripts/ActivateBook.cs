using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBook : MonoBehaviour
{
    public GameObject book;
    //public Book book1;

    public void ActivateFlowersBook()
    {
        book.SetActive(true);
        //book1 = FindObjectOfType<Book>();
        //book1.Start();

        Time.timeScale = 0;
    }

    public void DeactivateFlowersBook()
    {
        book.SetActive(false);
        Time.timeScale = 1;
    }
}
