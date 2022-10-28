using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FlowersName : MonoBehaviour
{
    public Transform FlowersList;

    void Awake()
    {
        FlowersList = GameObject.Find("FlowersList").GetComponent<Transform>();
        gameObject.transform.SetParent(FlowersList);
        gameObject.GetComponent<TMP_Text>().fontSize = 10;
        gameObject.GetComponent<TMP_Text>().alignment = TextAlignmentOptions.Center;
        gameObject.transform.localScale = new Vector3(0.5F, 0.2F, 0.5F);
    }

}
