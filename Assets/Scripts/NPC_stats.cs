using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NPC_stats
{
   public string name;
    public int likeability;
    public string keyVar;

    public NPC_stats(string keyVar_, string name_, int likeability_)
    {
        this.keyVar = keyVar_;
        this.name = name_;
        this.likeability = likeability_;
        createNPCData();
    }
    


    //Crea las stats de un npc que se van a usar en la visual novel, se almacenan sus datos en playerPrefs con un json
    public void createNPCData()
    {
       // NPC_stats newCharacter = new NPC_stats(name, 0);
        string json = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(keyVar, json);
    }


    //Crea todos los npcs del juego


    /// <summary>
    /// Consultas las stats de los npcs para tenerlas en cuenta en la VN
    /// </summary>
    /// <param name="keyVar">Key para consultar el personaje correspondiente</param>
    /// <returns>Se devuelve el int del stat</returns>
    /// 
    [YarnFunction("get_npc_likeability")]
    public static int getNPC_likeability(string keyVar)
    {
        string json = PlayerPrefs.GetString(keyVar);
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        return npc.likeability;
    }


    /// <summary>
    /// Primero se obtiene los datos del npc, se le cambia el valor correspondiente, y se vuelve a guardar.
    /// Es una función que se va a llamar también desde la VN, por ello usa [YarnFunction("")]
    /// </summary>
    /// <param name="keyVar">Key para encontrar al personaje en los PlayerPrefs</param>
    /// <param name="sumValue">Dato positivo o negativo para sumarlo al valor de un determinado stat</param>
   /* [YarnCommand("Add_npc_likeability")]
    public void addToLikeability(string keyVar, int sumValue)
    {
        Debug.Log("Entra al add likeability");
        string json = PlayerPrefs.GetString(keyVar);
        NPC_stats npc = JsonUtility.FromJson<NPC_stats>(json);
        npc.likeability -= sumValue;

        json = JsonUtility.ToJson(npc);
        PlayerPrefs.SetString(keyVar, json);
    }*/
    


}
