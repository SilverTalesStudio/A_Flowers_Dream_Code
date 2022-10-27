using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouquetDelivery : MonoBehaviour
{
    #region Variables

    [Header("PopUp")]
    public GameObject PopUp;

    public GameObject FlowersManager;

    private void Awake()
    {
        FlowersManager = GameObject.Find("FlowerManager");
    }
    #endregion

    #region Funciones

    public void EndDelivery()
    {
        if(FlowersManager.GetComponent<FlowersManager>()._flowersInBouquet.Count < 5)
        {
            ActivateBouquetDeliveryAlert();
        }
        else
        {
            foreach(string f in FlowersManager.GetComponent<FlowersManager>()._flowersInBouquet)
            {
                //HACER CHECKEO PUNTOS      
            }
        }
    }

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
