using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public Transform dropdownMenu;

    //find the selected index
    public void ReadNameInput(string inputText)
    {
       var _name = inputText;
        Debug.Log(_name);
        PlayerPrefs.SetString("PlayerName", _name);
    }
    public void ReadGenderInput(int value)
    {
        Debug.Log(value);
        List<TMPro.TMP_Dropdown.OptionData> options = dropdownMenu.GetComponent<TMPro.TMP_Dropdown>().options;
        var _gender = options[value].text;
        Debug.Log(_gender);
        PlayerPrefs.SetString("PlayerGender", _gender);

    }
}
