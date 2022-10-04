using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public Transform dropdownMenu;


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
    public void ReadGenderInput(int value)
    {
        Debug.Log(value);
        List<TMPro.TMP_Dropdown.OptionData> options = dropdownMenu.GetComponent<TMPro.TMP_Dropdown>().options;
        var _gender = options[value].text;
        Debug.Log(_gender);
        PlayerPrefs.SetString("PlayerGender", _gender);

    }
}
