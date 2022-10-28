using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class BouquetDelivery : MonoBehaviour
{
    #region Variables

    [Header("PopUp")]
    public GameObject PopUp;

    public GameObject FlowersManager;    
    public GameObject OrdersManager;
    public int puntos = 0;

    #endregion

    #region Funciones

    private void Awake()
    {
        FlowersManager = GameObject.Find("FlowersManager");
        OrdersManager = GameObject.Find("SceneManager");
    }

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
                // ENVIO DE VARIABLES A VN

                //FLOR FAVORITA U ODIADA
                if (GameObject.Find(f).GetComponent<DragAndDrop>().fav == OrdersManager.GetComponent<Orders_Manager>().clienteDelPedido)
                {
                    puntos += 2;
                }
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().hate == OrdersManager.GetComponent<Orders_Manager>().clienteDelPedido)
                {
                    puntos -= 2;
                }

                //COLOR AFIN O NO
                if (GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().colorDelPedido)
                {
                    puntos += 1;
                }
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().noColorDelPedido1
                        || GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().noColorDelPedido2)
                {
                    puntos -= 1;
                } else
                {
                    puntos += 1;
                }

                if (GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().sentimientoDelPedido)
                {
                    puntos += 1;
                }
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().noSentimientoDelPedido1
                        || GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().noSentimientoDelPedido2)
                {
                    puntos -= 1;
                }
                else
                {
                    puntos += 1;
                }
            }

            //Enviar puntos a VN
            if (puntos >= -12 && puntos < -4)
            {
                PlayerPrefs.SetString("resultadoMinijuego", "mal");
            }
            else if (puntos >= -4 && puntos < 4)
            {
                PlayerPrefs.SetString("resultadoMinijuego", "regular");
            }
            else if (puntos >= 4 && puntos < 12)
            {
                PlayerPrefs.SetString("resultadoMinijuego", "bien");
            }
            
        }
    }

    public void ActivateBouquetDeliveryAlert()
    {
        PopUp.SetActive(true);
        Time.timeScale = 0;

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            f.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    public void DeactivateBouquetDeliveryAlert()
    {
        PopUp.SetActive(false);
        Time.timeScale = 1;

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            f.GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    //YARN FUNCTIONS
    [YarnFunction("get_minigame_result")]
    public static string GetMinigameResult()
    {
        var result = PlayerPrefs.GetString("resultadoMinijuego");
        return result;
    }
    #endregion
}
