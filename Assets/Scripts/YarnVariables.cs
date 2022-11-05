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
}
