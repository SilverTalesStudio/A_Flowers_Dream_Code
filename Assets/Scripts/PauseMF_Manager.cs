using PlayFab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMF_Manager : MonoBehaviour

{
    public GameObject pause;
    public SceneChanger changer;
    [SerializeField] Button GuardarBtn;
    public GameObject popUp;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Guest") == 0)
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

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if (f.name != "FlowerBase")
                f.GetComponent<DragAndDrop>().enableClick = false;
        }
    }
    public void DeactivatePause()
    {
        pause.SetActive(false);
        Time.timeScale = 1;

        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if (f.name != "FlowerBase")
                f.GetComponent<DragAndDrop>().enableClick = true;
        }
    }
    public void GuardarEnMF()
    {
        StartCoroutine("GuardarMF_Coroutine");
         
    }


    IEnumerator GuardarMF_Coroutine()
    {
        yield return 0;
        Debug.Log("Entra guardar corrutina");
        var startMinigameNode = PlayerPrefs.GetString("currentMinigame");
        PlayerPrefs.SetString("nodeSaved", startMinigameNode);
        while (!PlayerPrefs.HasKey("YarnBasicSave"))
        {
            yield return 0;
        }
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
        string json = JsonUtility.ToJson(saveCurrentGameState);
        // Debug.Log("CURRENT GAME STATE"+json);
        SetUserData("UserData", json);
        yield return 0;
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
    void SetUserData(string key, string value)
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
                Debug.Log("SetData: " + error.ErrorMessage);
            }

            );
    }
}
