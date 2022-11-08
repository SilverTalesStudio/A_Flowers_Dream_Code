using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMF_Manager : MonoBehaviour

{
    public GameObject pause;
    public SceneChanger changer;
    public GameObject popUp;
    public void ActivatePause()
    {
        pause.SetActive(true);
    }
    public void DeactivatePause()
    {
        pause.SetActive(false);
    }
    public void GuardarEnMF()
    {
        var startMinigameNode = PlayerPrefs.GetString("currentMinigame");
        PlayerPrefs.SetString("nodeSaved", startMinigameNode);

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
    public void SalirEnMF()
    {
        GuardarEnMF();
        changer.changeScene("Menu");
    }
}
