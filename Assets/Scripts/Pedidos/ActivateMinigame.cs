using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMinigame : MonoBehaviour
{
    #region Headers

    [Header("Order")]
    public GameObject order;

    [Header("OrderSummary")]
    public GameObject orderSummary;

    #endregion

    #region

    public void ActivateFlowersMinigame()
    {
        order.SetActive(false);
        orderSummary.SetActive(true);
    }

    #endregion
}
