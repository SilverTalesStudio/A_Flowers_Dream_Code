using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnVariables : MonoBehaviour
{
	[YarnFunction("get_date")]
	public static string FinalDate()
	{
		//string json = PlayerPrefs.GetString("citaFin");
		//Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
		//return planes.Cita_Final;
		string cita = PlayerPrefs.GetString("citafinal");
		Debug.Log(cita);
		return cita;
	}

	[YarnFunction("get_infoMinerva")]
	public static string SagrarioTeCuenta()
	{
		//string json = PlayerPrefs.GetString("citaFin");
		//Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
		//return planes.Cita_Final;
		string info = PlayerPrefs.GetString("infoMinerva");
		Debug.Log(info);
		return info;
	}

	[YarnFunction("get_pintarPietro")]
	public static string pinturaPietro()
	{
		//string json = PlayerPrefs.GetString("citaFin");
		//Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
		//return planes.Cita_Final;
		string pintar = PlayerPrefs.GetString("dejaPintar");
		Debug.Log(pintar);
		return pintar;
	}
}
