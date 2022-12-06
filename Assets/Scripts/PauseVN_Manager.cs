using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PauseVN_Manager : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;
    public GameObject pause;
    public SceneChanger changer;
    public GameObject popUp;
    public void ActivatePause()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }
    public void DeactivatePause()
    {
        pause.SetActive(false);

    }
    public void ActivatePopUp()
    {
        popUp.SetActive(true);
        DeactivatePause();
    }
    public void DeactivatePopUp()
    {
        popUp.SetActive(false);
        ActivatePause();
    }
    public void Guardar()
    {
        PlayerPrefs.SetString("nodeSaved", runner.CurrentNodeName);

    }
    public void Salir()
    {
        Guardar();
        Time.timeScale = 1f;
        changer.changeScene("Menu");
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
