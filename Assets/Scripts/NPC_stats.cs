using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NPC_stats : MonoBehaviour
{
    public string name;
    public int hate;
    public int neutral;
    public int _love;


    public NPC_stats(string name, int hate, int neutral, int love)
    {
        this.name = name;
        this.hate = hate;
        this.neutral = neutral;
        this._love = love;
    }

    //Crea las stats de un npc que se van a usar en la visual novel, se almacenan sus datos en playerPrefs con un json
    public void createNPCData(string keyVar, string name)
    {
        NPC_stats newCharacter = new NPC_stats(name, 0, 0, 0);
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
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        return npc.hate;
    }

    [YarnFunction("get_npc_neutral")]
    public int getNPC_neutral(string keyVar)
    {
        string json = PlayerPrefs.GetString(keyVar);
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        return npc.neutral;
    }

    [YarnFunction("get_npc_love")]
    public int getNPC_love(string keyVar)
    {
        string json = PlayerPrefs.GetString(keyVar);
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        return npc._love;
    }

    public NPC_stats getNPC_stats(string keyVar)
    {
        string json = PlayerPrefs.GetString(keyVar);
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        return npc;
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
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        npc.hate -= sumValue;

        json = JsonUtility.ToJson(npc);
        PlayerPrefs.SetString(keyVar, json);
    }
    
    [YarnFunction("add_npc_neutral")]

    public void addToNeutral(string keyVar, int sumValue)
    {
        string json = PlayerPrefs.GetString(keyVar);
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        npc.neutral -= sumValue;

        json = JsonUtility.ToJson(npc);
        PlayerPrefs.SetString(keyVar, json);
    }

    [YarnFunction("add_npc_love")]
    public void addToLove(string keyVar, int sumValue)
    {
        string json = PlayerPrefs.GetString(keyVar);
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        npc._love -= sumValue;

        json = JsonUtility.ToJson(npc);
        PlayerPrefs.SetString(keyVar, json);
    }

}
