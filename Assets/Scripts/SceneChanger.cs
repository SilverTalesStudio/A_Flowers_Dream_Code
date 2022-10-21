using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextOrder;
    public UnityEvent listenOrder;
    string curretScene;

    public void playVN()
    {
        SceneManager.LoadScene("VisualNovel");
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
