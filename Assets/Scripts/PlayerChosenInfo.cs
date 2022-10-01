using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PlayerChosenInfo : MonoBehaviour
{
    private string _name = "name";
    private string _gender = "none";
   
    public void ReadNameInput(string inputText)
    {
        _name = inputText;
        PlayerPrefs.SetString("PlayerName", _name);
    }
    public void ReadGenderInput(string DropdownOption)
    {
        _gender = DropdownOption;
        PlayerPrefs.SetString("PlayerGender", _gender);

    }
    [YarnFunction("get_player_name")]
    public static string GetPlayerName()
    {
        var name = PlayerPrefs.GetString("PlayerName");
        return name;
    }

    [YarnFunction("get_player_gender")]
    public static string GetPlayerGender()
    {
        var gender = PlayerPrefs.GetString("PlayerGender");

        return gender;
    }
}
