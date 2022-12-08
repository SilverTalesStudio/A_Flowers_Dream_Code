using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextOrder;
    public UnityEvent listenOrder;
    public GameObject Loading;
    string curretScene;

    public void playVN()
    {
        Loading.SetActive(true);

        SceneManager.LoadScene("VisualNovel");
    }

    public void loadStartedVN()
    {
        if (PlayerPrefs.HasKey("nodeSaved"))
        {
           playVN();
        }
    }

    //Cambio de escena genérico
    public void changeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    private void Start()
    {
        nextOrder = "NaN";
        listenOrder.AddListener(GoToOrderManagment);
    }

    private void FixedUpdate()
    {
        if (nextOrder == PlayerPrefs.GetString("clienteActual"))
        {
            listenOrder.Invoke();
        }
    }

    void GoToOrderManagment()
    {
        changeScene("MinijuegoFlores");
    }

}
