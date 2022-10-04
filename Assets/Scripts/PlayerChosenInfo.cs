using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class PlayerChosenInfo : MonoBehaviour
{


    //Las funciones con [YarnFunction("nombreDeFuncion")] que se pueden usar en los archivos .yarn con el nombre indicado entre corchetes
   
    //Consulta el nombre del jugador en los playerPrefs y lo devuelve, para poder usarlo en la visual novel
    [YarnFunction("get_player_name")]
    public static string GetPlayerName()
    {
        var name = PlayerPrefs.GetString("PlayerName");
        return name;
    }
    //Consulta el género del jugador en los playerPrefs y lo devuelve, para poder usarlo en la visual novel
    [YarnFunction("get_player_gender")]
    public static string GetPlayerGender()
    {
        var gender = PlayerPrefs.GetString("PlayerGender");

        return gender;
    }
}
