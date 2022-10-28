using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PauseVN_Manager : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;
    public GameObject pause;
    public SceneChanger changer;
    public void ActivatePause()
    {
        pause.SetActive(true);
    }
    public void DeactivatePause()
    {
        pause.SetActive(false);
    }

    public void Guardar()
    {
        PlayerPrefs.SetString("nodeSaved", runner.CurrentNodeName);

    }
    public void Salir()
    {
        Guardar();
        changer.changeScene("Menu");
    }
    
}
