using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Yarn.Unity;

public class AfinityOrder : MonoBehaviour
{
    static List<NPC_stats> npcList;

    private void Awake()
    {
        Debug.Log("START AFIFNIT");
        npcList = new List<NPC_stats>();
        
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_sagrario"));
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_pietro"));
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_allan"));
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_ethan"));
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_sophie"));
        
        
        //Testing
        /*
        npcList.Add(new NPC_stats("NPC_sagrario_prueba","Sagrario",-3));
        npcList.Add(new NPC_stats("NPC_pietro_prueba", "Pietro", -200));
        npcList.Add(new NPC_stats("NPC_allan_prueba", "Allan", 20));
        npcList.Add(new NPC_stats("NPC_ethan_prueba", "Ethan", -170));
        npcList.Add(new NPC_stats("NPC_sophie_prueba", "Sophie", 50));
       */
       // Debug.Log(npcList.Last().name);
    }


    [YarnFunction("get_last_node")]
    public static string getLastNode()
    {
        Debug.Log("Cantidad de finales neturs/buenos: "+npcList.Count);
        npcList=npcList.OrderByDescending(x => x.likeability).ToList();
        string lastNode = npcList.Last().name;
        Debug.Log(npcList.Last().name);
        return lastNode;
    }
    [YarnFunction("get_nodes_left")]
    public static int getNodesLeft()
    {

        return npcList.Count;
    }
    [YarnCommand("remove_last_node")]
    public static void removeLastNode()
    {
        if (npcList.Count > 0)
        {
            npcList.RemoveAt(npcList.Count - 1);
        }
    }
    [YarnCommand("remove_bad_ends")]
    public static void removeBadEnds()
    {
        Debug.Log("Remove bad ends");
        List<NPC_stats> badEndsIdx = new List<NPC_stats>();
        for (int i = 0; i < npcList.Count; i++)
        {
            if (npcList[i].likeability<-100)
            {
                badEndsIdx.Add(npcList[i]);
            }
        }
        for (int i = 0; i < badEndsIdx.Count; i++)
        {
            npcList.RemoveAll(x => x.keyVar == badEndsIdx[i].keyVar);
        }
    }
}

