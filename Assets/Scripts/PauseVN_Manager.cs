using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PauseVN_Manager : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;
    [SerializeField] GameObject GuardarBtn;
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

        StartCoroutine("Guardar_Coroutine");
    }
    IEnumerator Guardar_Coroutine()
    {
        yield return 0;
        PlayerPrefs.SetString("nodeSaved", runner.CurrentNodeName);
        runner.SaveStateToPlayerPrefs();
        while (!PlayerPrefs.HasKey("YarnBasicSave"))
        {
            yield return 0;
        }
        SaveState saveCurrentGameState = new SaveState(
            pjname_: PlayerPrefs.GetString("PlayerName"),
            pjgender_: PlayerPrefs.GetString("PlayerGender"),
            pjcharacter_: PlayerPrefs.GetString("PlayerMainCharacter"),
            nodesaved_: PlayerPrefs.GetString("nodeSaved"),
            planesfinde_: PlayerPrefs.GetString("Planes"),
            musicaactual_: "none",
            variablesinyarn_: PlayerPrefs.GetString("YarnBasicSave"),
            npcallan_: PlayerPrefs.GetString("NPC_allan"),
            npcSophie_: PlayerPrefs.GetString("NPC_sophie"),
            npcEthan_: PlayerPrefs.GetString("NPC_ethan"),
            npcPietro_: PlayerPrefs.GetString("NPC_pietro"),
            npcsagrario_: PlayerPrefs.GetString("NPC_sagrario")

            );

        yield return 0;
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
