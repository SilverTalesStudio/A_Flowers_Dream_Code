using PlayFab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class PauseVN_Manager : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;
    [SerializeField] Button GuardarBtn;
    public GameObject pause;
    public SceneChanger changer;
    public GameObject popUp;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Guest")==0)
        {
            GuardarBtn.interactable = false;
        }
        else
        {
            GuardarBtn.interactable = true;
        }
    }

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

        StartCoroutine("Guardar_Coroutine");
    }
    IEnumerator Guardar_Coroutine()
    {
        yield return 0;
       // Debug.Log("Entra guardar corrutina");
        PlayerPrefs.SetString("nodeSaved", runner.CurrentNodeName);
        runner.SaveStateToPlayerPrefs();
        while (!PlayerPrefs.HasKey("YarnBasicSave"))
        {
            yield return 0;
        }
        Debug.Log("runner guarda");
        SaveState saveCurrentGameState = new SaveState(
            PlayerPrefs.GetString("PlayerName"),
            PlayerPrefs.GetString("PlayerGender"),
            PlayerPrefs.GetString("PlayerMainCharacter"),
            PlayerPrefs.GetString("nodeSaved"),
            PlayerPrefs.GetString("Planes"),
             PlayerPrefs.GetString("currentMusic"),
            PlayerPrefs.GetString("YarnBasicSave"),
            PlayerPrefs.GetString("NPC_allan"),
           PlayerPrefs.GetString("NPC_sophie"),
             PlayerPrefs.GetString("NPC_ethan"),
            PlayerPrefs.GetString("NPC_pietro"),
             PlayerPrefs.GetString("NPC_sagrario")

            );
       // Debug.Log(saveCurrentGameState.PjName);
       // Debug.Log(saveCurrentGameState.nodeSaved);
        string json= JsonUtility.ToJson(saveCurrentGameState);
       // Debug.Log("CURRENT GAME STATE"+json);
        SetUserData("UserData",json);
        yield return 0;
    }
    public void Salir()
    {
        //Guardar();
        Time.timeScale = 1f;
        changer.changeScene("Menu");
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }

    void SetUserData (string key, string value)
    {
        PlayFabClientAPI.UpdateUserData(
            new PlayFab.ClientModels.UpdateUserDataRequest()
            {
                Data = new Dictionary<string, string>()
                {
                    {key,value}
                }
            },
            response =>
            {
                Debug.Log("Setteo de data successfull");
            },
            error =>
            {
                Debug.Log("SetData: "+error.ErrorMessage);
            }

            );
    }

}
