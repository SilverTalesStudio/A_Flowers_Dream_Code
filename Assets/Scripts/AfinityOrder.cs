using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Yarn.Unity;

public class AfinityOrder : MonoBehaviour
{
    static List<NPC_stats> npcList;

    private void Start()
    {
        npcList = new List<NPC_stats>();
        
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_sagrario"));
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_pietro"));
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_allan"));
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_ethan"));
        npcList.Add(NPC_stats.GetNPC_Stats("NPC_sophie"));
        

        //Testing
       /* npcList.Add(new NPC_stats("NPC_sagrario_prueba","Sagrario",-3));
        npcList.Add(new NPC_stats("NPC_pietro_prueba", "Pietro", 8));
        npcList.Add(new NPC_stats("NPC_allan_prueba", "Allan", 20));
        npcList.Add(new NPC_stats("NPC_ethan_prueba", "Ethan", -5));
        npcList.Add(new NPC_stats("NPC_sophie_prueba", "Sophie", 2));
       */
       // Debug.Log(npcList.Last().name);
    }


    [YarnFunction("get_last_node")]
    public static string getLastNode()
    {

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
}

