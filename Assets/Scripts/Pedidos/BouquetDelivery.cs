using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouquetDelivery : MonoBehaviour
{
    #region Variables

    [Header("PopUp")]
    public GameObject PopUp;

    #endregion

    #region Funciones

    public void ActivateBouquetDeliveryAlert()
    {
        PopUp.SetActive(true);
        Time.timeScale = 0;
    }

    public void DeactivateBouquetDeliveryAlert()
    {
        PopUp.SetActive(false);
        Time.timeScale = 1;
    }

    #endregion
}
