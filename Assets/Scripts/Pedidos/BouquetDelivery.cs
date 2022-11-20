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
    public GameObject Loading;
    private int favPuntos = 0;
    private int colorPuntos = 0;
    private int SentimientoPuntos = 0;
    private string favRes;
    private string colorRes;
    private string SentimientoRes;

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
            Loading.SetActive(true);
            foreach(string f in FlowersManager.GetComponent<FlowersManager>()._flowersInBouquet)
            {
                // ENVIO DE VARIABLES A VN
                
                //-----------CHEQUEO--------------
                //FLOR FAVORITA U ODIADA
                if (GameObject.Find(f).GetComponent<DragAndDrop>().fav == OrdersManager.GetComponent<Orders_Manager>().clienteDelPedido)
                {
                    favPuntos += 1;
                    colorPuntos += 1;
                    SentimientoPuntos += 1;
                }
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().hate == OrdersManager.GetComponent<Orders_Manager>().clienteDelPedido)
                {
                    favPuntos -= 1;
                    colorPuntos -= 1;
                    SentimientoPuntos -= 1;
                }
                else
                {
                    //COLOR AFIN O NO
                    if (GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().colorDelPedido)
                    {
                        colorPuntos += 1;
                    }
                    else if (GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().noColorDelPedido1
                            || GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().noColorDelPedido2)
                    {
                        colorPuntos -= 1;
                    }
                    /*
                    else
                    {
                        colorPuntos += 1;
                    }
                    */
                    //SENTIMIENTO AFIN O NO
                    if (GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().sentimientoDelPedido)
                    {
                        SentimientoPuntos += 1;
                    }
                    else if (GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().noSentimientoDelPedido1
                            || GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().noSentimientoDelPedido2)
                    {
                        SentimientoPuntos -= 1;
                    }
                    /*
                    else
                    {
                        SentimientoPuntos += 1;
                    }
                    */
                }

                
            }
            //--------------------------------

            //-----------RESULTADOS--------------

            //FLOR FAV
            if (favPuntos == -1)
            {
                favRes = "mal";                
            }
            else if (favPuntos == 0)
            {
                favRes = "regular";
            }
            else if (favPuntos == 1)
            {
                favRes = "bien";
            }

            //COLOR
            if (colorPuntos >= -5 && colorPuntos <= -2)
            {
                colorRes = "mal";               
            }
            else if (colorPuntos >= -1 && colorPuntos <= 1)
            {
                colorRes = "regular";
            }
            else if (colorPuntos >= 2 && colorPuntos <= 5)
            {
                colorRes = "bien";
            }

            //SENTIMIENTO
            if (SentimientoPuntos >= -5 && SentimientoPuntos <= -2)
            {
                SentimientoRes = "mal";
            }
            else if (SentimientoPuntos >= -1 && SentimientoPuntos <= 1)
            {
                SentimientoRes = "regular";
            }
            else if (SentimientoPuntos >= 2 && SentimientoPuntos <= 5)
            {
                SentimientoRes = "bien";
            }
            //------------------------------------

            Debug.Log(favRes);
            Debug.Log(colorRes);
            Debug.Log(SentimientoRes);

            //RESULTADO FINAL
            if (favRes == colorRes || favRes == SentimientoRes)
            {
                Debug.Log(favRes);
                PlayerPrefs.SetString("resultadoMinijuego", favRes);
            }
            else if (colorRes == SentimientoRes)
            {
                Debug.Log(colorRes);
                PlayerPrefs.SetString("resultadoMinijuego", colorRes);
            }
            else
            {
                Debug.Log("NEUTRO");
                PlayerPrefs.SetString("resultadoMinijuego", "regular");
            }
            OrdersManager.GetComponent<SceneChanger>().changeScene("VisualNovel");
        }
    }

    public void ActivateBouquetDeliveryAlert()
    {
        PopUp.SetActive(true);
        Time.timeScale = 0;

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if(f.name != "FlowerBase")
                f.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    public void DeactivateBouquetDeliveryAlert()
    {
        PopUp.SetActive(false);
        Time.timeScale = 1;

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if (f.name != "FlowerBase")
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
