using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowersManager : MonoBehaviour
{
    public GameObject FlowersInMenu;
    public List<string> _flowersInBouquet = new List<string>();

    private void Awake()
    {
        FlowersInMenu = GameObject.Find("FlowersList");
    }

    public void AddFlowers(string flower)
    {
        _flowersInBouquet.Add(flower);
        FlowersInMenu.GetComponent<FlowersSpawnList>()._flowers.Remove(flower.Replace("(Clone)", "").Trim());
        if (_flowersInBouquet.Count == 5)
        {
            foreach (string f in FlowersInMenu.GetComponent<FlowersSpawnList>()._flowers)
            {
                GameObject.Find(f + "(Clone)").GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }

    public void DeleteFlowers(string flower)
    {
        _flowersInBouquet.Remove(flower);
        FlowersInMenu.GetComponent<FlowersSpawnList>()._flowers.Add(flower.Replace("(Clone)", "").Trim());
 
        foreach (string f in FlowersInMenu.GetComponent<FlowersSpawnList>()._flowers)
        {
            GameObject.Find(f + "(Clone)").GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void ConfirmDelivery()
    {

    }
}
