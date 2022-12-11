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

    [Header("Part_4")]
    public GameObject Part_4;

    [Header("Part_5")]
    public GameObject Part_5;

    [Header("Part_6")]
    public GameObject Part_6;

    [Header("Part_7")]
    public GameObject Part_7;

    [Header("Part_8")]
    public GameObject Part_8;

    [Header("Part_9")]
    public GameObject Part_9;

    [Header("Part_10")]
    public GameObject Part_10;

    #endregion

    #region Book

    public void ActivatePart_1()
    {
        Part_1.SetActive(true);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
    }

    public void ActivatePart_2()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(true);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
    }

    public void ActivatePart_3()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(true);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
    }

    public void ActivatePart_4()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(true);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
    }

    public void ActivatePart_5()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(true);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
    }

    public void ActivatePart_6()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(true);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
    }
    public void ActivatePart_7()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(true);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
    }

    public void ActivatePart_8()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(true);
        Part_9.SetActive(false);
        Part_10.SetActive(false);
    }

    public void ActivatePart_9()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(true);
        Part_10.SetActive(false);
    }

    public void ActivatePart_10()
    {
        Part_1.SetActive(false);
        Part_2.SetActive(false);
        Part_3.SetActive(false);
        Part_4.SetActive(false);
        Part_5.SetActive(false);
        Part_6.SetActive(false);
        Part_7.SetActive(false);
        Part_8.SetActive(false);
        Part_9.SetActive(false);
        Part_10.SetActive(true);
    }

    #endregion
}
