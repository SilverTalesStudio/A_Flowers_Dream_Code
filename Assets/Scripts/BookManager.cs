using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    #region Headers

    [Header("Part_1")]
    public GameObject Part_1;

    [Header("Part_2")]
    public GameObject Part_2;

    [Header("Part_3")]
    public GameObject Part_3;

    #endregion

    #region Book

    public void ActivatePart_1()
    {
        Part_1.SetActive(true);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
    }

    public void ActivatePart_2()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(true);
        Part_3.SetActive(false);
    }

    public void ActivatePart_3()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(true);
    }

    #endregion
}
