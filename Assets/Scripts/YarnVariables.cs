using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnVariables : MonoBehaviour
{
	[YarnFunction("get_date")]
	public static string FinalDate()
	{
		string cita = PlayerPrefs.GetString("citafinal");
		Debug.Log(cita);
		return cita;
	}

	[YarnFunction("get_infoMinerva")]
	public static string SagrarioTeCuenta()
	{

		string info = PlayerPrefs.GetString("infoMinerva");
		Debug.Log(info);
		return info;
	}

	[YarnFunction("get_pintarPietro")]
	public static string pinturaPietro()
	{

		string pintar = PlayerPrefs.GetString("dejaPintar");
		Debug.Log(pintar);
		return pintar;
	}

	[YarnFunction("get_libroEthanLeido")]
	public static string libroEthan()
	{

		string libro = PlayerPrefs.GetString("libroLeido");
		Debug.Log(libro);
		return libro;
	}

	[YarnFunction("get_conciertoSophie")]
	public static string conciertoS_Cancelado()
	{

		string concierto = PlayerPrefs.GetString("conciertoCancelado");
		Debug.Log(concierto);
		return concierto;
	}
}
