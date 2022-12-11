using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalleryManager : MonoBehaviour
{
    public GameObject AllanIlusSem1Fem;
    public GameObject AllanIlusSem3Fem;
    public GameObject EthanIlusSem1Fem;
    public GameObject EthanIlusSem2Fem;
    public GameObject EthanIlusSem3Fem;
    public GameObject SophieIlusSem2Fem;
    public GameObject SophieIlusSem3Fem;

    public GameObject AllanIlusSem1Masc;
    public GameObject AllanIlusSem3Masc;
    public GameObject EthanIlusSem1Masc;
    public GameObject EthanIlusSem2Masc;
    public GameObject EthanIlusSem3Masc;
    public GameObject SophieIlusSem2Masc;
    public GameObject SophieIlusSem3Masc;

    void Awake()
    {
        //FEM
        //Allan
        if(PlayerPrefs.GetString("AllanIllus1FEM") == "yes")
        {
            AllanIlusSem1Fem.GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetString("AllanIllus2FEM") == "yes")
        {
            AllanIlusSem3Fem.GetComponent<Image>().color = Color.white;
        }
        //Ethan
        if (PlayerPrefs.GetString("EthanIllus1FEM") == "yes")
        {
            EthanIlusSem1Fem.GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetString("EthanIllus2FEM") == "yes")
        {
            EthanIlusSem2Fem.GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetString("EthanIllus3FEM") == "yes")
        {
            EthanIlusSem3Fem.GetComponent<Image>().color = Color.white;
        }
        //Sophie
        if (PlayerPrefs.GetString("SophieIllus1FEM") == "yes")
        {
            SophieIlusSem2Fem.GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetString("SophieIllus2FEM") == "yes")
        {
            SophieIlusSem3Fem.GetComponent<Image>().color = Color.white;
        }

        //MASC
        //Allan
        if (PlayerPrefs.GetString("AllanIllus1MAS") == "yes")
        {
            AllanIlusSem1Masc.GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetString("AllanIllus2MAS") == "yes")
        {
            AllanIlusSem3Masc.GetComponent<Image>().color = Color.white;
        }
        //Ethan
        if (PlayerPrefs.GetString("EthanIllus1MAS") == "yes")
        {
            EthanIlusSem1Masc.GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetString("EthanIllus2MAS") == "yes")
        {
            EthanIlusSem2Masc.GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetString("EthanIllus3MAS") == "yes")
        {
            EthanIlusSem3Masc.GetComponent<Image>().color = Color.white;
        }
        //Sophie
        if (PlayerPrefs.GetString("SophieIllus1MAS") == "yes")
        {
            SophieIlusSem2Masc.GetComponent<Image>().color = Color.white;
        }
        if (PlayerPrefs.GetString("SophieIllus2MAS") == "yes")
        {
            SophieIlusSem3Masc.GetComponent<Image>().color = Color.white;
        }
    }


}
