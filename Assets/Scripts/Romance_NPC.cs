using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Romance_NPC : MonoBehaviour
{
    private string _name;
    private int _hate;
    private int _neutral;
    private int _love;


    public Romance_NPC(string name, int hate, int neutral, int love)
    {
        this.name = name;
        this._hate = hate;
        this._neutral = neutral;
        this._love = love;
    }

    //Crea las stats de un npc que se van a usar en la visual novel, se almacenan sus datos en playerPrefs con un json
    public void createNPCData(string keyVar, string name)
    {
        Romance_NPC newCharacter = new Romance_NPC(name, 0, 0, 0);
        string json = JsonUtility.ToJson(newCharacter);
        PlayerPrefs.SetString(keyVar, json);
    }

    /// <summary>
    /// Consultas las stats de los npcs para tenerlas en cuenta en la VN
    /// </summary>
    /// <param name="keyVar">Key para consultar el personaje correspondiente</param>
    /// <returns>Se devuelve el int del stat</returns>
    /// 
    [YarnFunction("get_npc_hate")]
    public int getNPC_hate(string keyVar)
    {
        string json = PlayerPrefs.GetString(keyVar);
        Romance_NPC npc = JsonUtility.FromJson<Romance_NPC>(json);
        return npc._hate;
    }

    [YarnFunction("get_npc_neutral")]
    public int getNPC_neutral(string keyVar)
    {
        string json = PlayerPrefs.GetString(keyVar);
        Romance_NPC npc = JsonUtility.FromJson<Romance_NPC>(json);
        return npc._neutral;
    }

    [YarnFunction("get_npc_love")]
    public int getNPC_love(string keyVar)
    {
        string json = PlayerPrefs.GetString(keyVar);
        Romance_NPC npc = JsonUtility.FromJson<Romance_NPC>(json);
        return npc._love;
    }

    /// <summary>
    /// Primero se obtiene los datos del npc, se le cambia el valor correspondiente, y se vuelve a guardar.
    /// Es una función que se va a llamar también desde la VN, por ello usa [YarnFunction("")]
    /// </summary>
    /// <param name="keyVar">Key para encontrar al personaje en los PlayerPrefs</param>
    /// <param name="sumValue">Dato positivo o negativo para sumarlo al valor de un determinado stat</param>
    [YarnFunction("add_npc_hate")]
    public void addToHate(string keyVar, int sumValue)
    {
        string json = PlayerPrefs.GetString(keyVar);
        Romance_NPC npc = JsonUtility.FromJson<Romance_NPC>(json);
        npc._hate -= sumValue;

        json = JsonUtility.ToJson(npc);
        PlayerPrefs.SetString(keyVar, json);
    }
    
    [YarnFunction("add_npc_neutral")]

    public void addToNeutral(string keyVar, int sumValue)
    {
        string json = PlayerPrefs.GetString(keyVar);
        Romance_NPC npc = JsonUtility.FromJson<Romance_NPC>(json);
        npc._neutral -= sumValue;

        json = JsonUtility.ToJson(npc);
        PlayerPrefs.SetString(keyVar, json);
    }

    [YarnFunction("add_npc_love)"]
    public void addToLove(string keyVar, int sumValue)
    {
        string json = PlayerPrefs.GetString(keyVar);
        Romance_NPC npc = JsonUtility.FromJson<Romance_NPC>(json);
        npc._love -= sumValue;

        json = JsonUtility.ToJson(npc);
        PlayerPrefs.SetString(keyVar, json);
    }

}
