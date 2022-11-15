using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
   // public Transform dropdownMenu;
    public ToggleGroup toggleGroup;
    public ToggleGroup personajesGroup;

    private void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
    private void Start()
    {
        createNPCs();
        new Planes_Finde(false, false, false, false, false, false);
        PlayerPrefs.SetString("nodeSaved", "Semana1");
        PlayerPrefs.SetString("currentMinigame", "none");
        PlayerPrefs.SetString("PlayerName", "Luc�a");
        PlayerPrefs.SetString("PlayerGender", "F");
    }
    //Lee lo que se escribe dentro del Input Text Field va dentro del OnEndString del gameobject
    // y lo guarda en PlayerPrefs
    public void ReadNameInput(string inputText)
    {
       var _name = inputText;
        Debug.Log(_name);
        PlayerPrefs.SetString("PlayerName", _name);
    }

    //Lee la seleccion de g�nero del DropDown menu
    // y lo guarda en PlayerPrefs
    public void ReadGenderInput(bool value)
    {
        string gender= toggleGroup.GetFirstActiveToggle().name;
        string savedGender = "F";
        if (gender=="�l")
        {
            savedGender = "M";
        }
        else if (gender == "Elle")
        {
            savedGender = "NB";
        }
        else
        {
            savedGender = "F";
        }
        Debug.Log(savedGender);
        PlayerPrefs.SetString("PlayerGender", savedGender);

    }

    public void ReadMainCharacterInput(bool value)
    {
        string mainCharacter = toggleGroup.GetFirstActiveToggle().name;
        string savedMainCharacter = "primero";
        if (mainCharacter == "Personaje_1")
        {
            savedMainCharacter = "primero";
        }
        else 
        {
            savedMainCharacter = "segundo";
        }
        Debug.Log(savedMainCharacter);
        PlayerPrefs.SetString("PlayerMainCharacter", savedMainCharacter);

    }
    public void createNPCs()
    {
        new NPC_stats("NPC_sagrario","Sagrario",0);
        new NPC_stats("NPC_ethan", "Ethan", 0);
        new NPC_stats("NPC_allan", "Allan", 0);
        new NPC_stats("NPC_sophie", "Sopie", 0);
        new NPC_stats("NPC_pietro", "Pietro", 0);


    }
   
}
