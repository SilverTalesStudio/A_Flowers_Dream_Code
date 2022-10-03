using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PlayerChosenInfo : MonoBehaviour
{

   

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
