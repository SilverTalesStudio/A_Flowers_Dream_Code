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
    public GameObject Fade;
    private float favPuntos = 0;
    private float colorPuntos = 0;
    private float SentimientoPuntos = 0;
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

    IEnumerator FadeOut()
    {
        Loading.SetActive(true);
        yield return new WaitForSeconds(2);               
        Fade.SetActive(true);
        Fade.GetComponent<Animator>().Play("FadeOut");
        yield return new WaitForSeconds(1);
        OrdersManager.GetComponent<SceneChanger>().changeScene("VisualNovel");
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
                
                //-----------CHEQUEO--------------
                //FLOR FAVORITA U ODIADA
                if (GameObject.Find(f).GetComponent<DragAndDrop>().fav == OrdersManager.GetComponent<Orders_Manager>().clienteDelPedido)
                {
                    favPuntos += 1;
                }
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().hate == OrdersManager.GetComponent<Orders_Manager>().clienteDelPedido)
                {
                    favPuntos -= 1;
                }
                //COLOR AFIN O NO
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().colorDelPedido)               
                {
                    colorPuntos += 5 / GameObject.Find(f).GetComponent<DragAndDrop>().fTotalColor;
                }
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().noColorDelPedido1
                        || GameObject.Find(f).GetComponent<DragAndDrop>().fcolor == OrdersManager.GetComponent<Orders_Manager>().noColorDelPedido2)
                {
                    colorPuntos -= 5 / GameObject.Find(f).GetComponent<DragAndDrop>().fTotalColor; ;
                }
                //SENTIMIENTO AFIN O NO
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().sentimientoDelPedido)
                {
                     SentimientoPuntos += 5 / GameObject.Find(f).GetComponent<DragAndDrop>().fTotalFeeling;
                }
                else if (GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().noSentimientoDelPedido1
                            || GameObject.Find(f).GetComponent<DragAndDrop>().ffeeling == OrdersManager.GetComponent<Orders_Manager>().noSentimientoDelPedido2)
                {
                     SentimientoPuntos -= 5 / GameObject.Find(f).GetComponent<DragAndDrop>().fTotalFeeling;
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
            if (colorPuntos <= -1.66f)
            {
                colorRes = "mal";               
            }
            else if (colorPuntos > -1.66f && colorPuntos < 1.66f)
            {
                colorRes = "regular";
            }
            else if (colorPuntos >= 1.66f)
            {
                colorRes = "bien";
            }

            //SENTIMIENTO
            if (SentimientoPuntos <= -1.66f)
            {
                SentimientoRes = "mal";
            }
            else if (SentimientoPuntos > -1.66f && SentimientoPuntos < 1.66f)
            {
                SentimientoRes = "regular";
            }
            else if (SentimientoPuntos > 1.66f)
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
                PlayerPrefs.SetString("resultadoMinijuego", favRes);
            }
            else if (colorRes == SentimientoRes)
            {
                PlayerPrefs.SetString("resultadoMinijuego", colorRes);
            }
            else
            {
                PlayerPrefs.SetString("resultadoMinijuego", "regular");
            }
            StartCoroutine(FadeOut());
        }
    }    

    public void ActivateBouquetDeliveryAlert()
    {
        PopUp.SetActive(true);
        Time.timeScale = 0;

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if(f.name != "FlowerBase")
                f.GetComponent<PolygonCollider2D>().enabled = false;
        }
    }

    public void DeactivateBouquetDeliveryAlert()
    {
        PopUp.SetActive(false);
        Time.timeScale = 1;

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if (f.name != "FlowerBase")
                f.GetComponent<PolygonCollider2D>().enabled = true;
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
