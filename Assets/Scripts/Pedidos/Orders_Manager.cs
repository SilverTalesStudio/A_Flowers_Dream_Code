using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Orders_Manager : MonoBehaviour
{
    #region variables

    //Variable del personaje que hace el pedido
    private string character;

    //Variable del pedido
    private int order;

    //Variable del texto
    private string text_order;
    private string text_orderSummary;

    public TMP_Text Order;
    public TMP_Text Summary;

    #endregion

    #region Awake
    private void Awake()
    {
        character = PlayerPrefs.GetString("clienteActual");
        order = Random.Range(1, 11);

        if (character == "Sophie")
        {
            SophieOrder(order);
        }
        else if(character == "Ethan")
        {
            LigonOrder(order);
        }
        else if(character == "Allan")
        {
            CachopanOrder(order);
        }
        else if(character == "Pietro")
        {
            PietroOrder(order);
        }
        else if(character == "Abuelaentrañable")
        {
            AbuelaOrder(order);
        }
        else
        {
            Debug.Log("Error al pasar el personaje en el pedido");
        }
        
    }
    #endregion

    #region Funciones
    private void SophieOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Pedido1 Sophie";
                text_orderSummary = "ResumenSophie1";
                break;

            case 2:
                text_order = "Pedido2 Sophie";
                text_orderSummary = "ResumenSophie2";
                break;

            case 3:
                text_order = "Pedido3 Sophie";
                text_orderSummary = "ResumenSophie3";
                break;

            case 4:
                text_order = "Pedido4 Sophie";
                text_orderSummary = "ResumenSophie4";
                break;

            case 5:
                text_order = "Pedido5 Sophie";
                text_orderSummary = "ResumenSophie5";
                break;

            case 6:
                text_order = "Pedido6 Sophie";
                text_orderSummary = "ResumenSophie6";
                break;

            case 7:
                text_order = "Pedido7 Sophie";
                text_orderSummary = "ResumenSophie7";
                break;

            case 8:
                text_order = "Pedido8 Sophie";
                text_orderSummary = "ResumenSophie8";
                break;

            case 9:
                text_order = "Pedido9 Sophie";
                text_orderSummary = "ResumenSophie9";
                break;

            case 10:
                text_order = "Pedido10 Sophie";
                text_orderSummary = "ResumenSophie10";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    private void LigonOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Pedido1 Ligon";
                text_orderSummary = "ResumenLigon1";
                break;

            case 2:
                text_order = "Pedido2 Ligon";
                text_orderSummary = "ResumenLigon2";
                break;

            case 3:
                text_order = "Pedido3 Ligon";
                text_orderSummary = "ResumenLigon3";
                break;

            case 4:
                text_order = "Pedido4 Ligon";
                text_orderSummary = "ResumenLigon4";
                break;

            case 5:
                text_order = "Pedido5 Ligon";
                text_orderSummary = "ResumenLigon5";
                break;

            case 6:
                text_order = "Pedido6 Ligon";
                text_orderSummary = "ResumenLigon6";
                break;

            case 7:
                text_order = "Pedido7 Ligon";
                text_orderSummary = "ResumenLigon7";
                break;

            case 8:
                text_order = "Pedido8 Ligon";
                text_orderSummary = "ResumenLigon8";
                break;

            case 9:
                text_order = "Pedido9 Ligon";
                text_orderSummary = "ResumenLigon9";
                break;

            case 10:
                text_order = "Pedido10 Ligon";
                text_orderSummary = "ResumenLigon10";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    private void CachopanOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Pedido1 Cachopan";
                text_orderSummary = "ResumenCachopan1";
                break;

            case 2:
                text_order = "Pedido2 Cachopan";
                text_orderSummary = "ResumenCachopan2";
                break;

            case 3:
                text_order = "Pedido3 Cachopan";
                text_orderSummary = "ResumenCachopan3";
                break;

            case 4:
                text_order = "Pedido4 Cachopan";
                text_orderSummary = "ResumenCachopan4";
                break;

            case 5:
                text_order = "Pedido5 Cachopan";
                text_orderSummary = "ResumenCachopan5";
                break;

            case 6:
                text_order = "Pedido6 Cachopan";
                text_orderSummary = "ResumenCachopan6";
                break;

            case 7:
                text_order = "Pedido7 Cachopan";
                text_orderSummary = "ResumenCachopan7";
                break;

            case 8:
                text_order = "Pedido8 Cachopan";
                text_orderSummary = "ResumenCachopan8";
                break;

            case 9:
                text_order = "Pedido9 Cachopan";
                text_orderSummary = "ResumenCachopan9";
                break;

            case 10:
                text_order = "Pedido10 Cachopan";
                text_orderSummary = "ResumenCahopan10";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    private void PietroOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Pedido1 Pietro";
                text_orderSummary = "ResumenPietro1";
                break;

            case 2:
                text_order = "Pedido2 Pietro";
                text_orderSummary = "ResumenPietro2";
                break;

            case 3:
                text_order = "Pedido3 Pietro";
                text_orderSummary = "ResumenPietro3";
                break;

            case 4:
                text_order = "Pedido4 Pietro";
                text_orderSummary = "ResumenPietro4";
                break;

            case 5:
                text_order = "Pedido5 Pietro";
                text_orderSummary = "ResumenPietro5";
                break;

            case 6:
                text_order = "Pedido6 Pietro";
                text_orderSummary = "ResumenPietro6";
                break;

            case 7:
                text_order = "Pedido7 Pietro";
                text_orderSummary = "ResumenPietro7";
                break;

            case 8:
                text_order = "Pedido8 Pietro";
                text_orderSummary = "ResumenPietro8";
                break;

            case 9:
                text_order = "Pedido9 Pietro";
                text_orderSummary = "ResumenPietro9";
                break;

            case 10:
                text_order = "Pedido10 Pietro";
                text_orderSummary = "ResumenPietro10";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }


    private void AbuelaOrder(int order)
    {
        switch (order)
        {
            case 1:
                text_order = "Pedido1 Abuela";
                text_orderSummary = "ResumenAbuela1";
                break;

            case 2:
                text_order = "Pedido2 Abuela";
                text_orderSummary = "ResumenAbuela2";
                break;

            case 3:
                text_order = "Pedido3 Abuela";
                text_orderSummary = "ResumenAbuela3";
                break;

            case 4:
                text_order = "Pedido4 Abuela";
                text_orderSummary = "ResumenAbuela4";
                break;

            case 5:
                text_order = "Pedido5 Abuela";
                text_orderSummary = "ResumenAbuela5";
                break;

            case 6:
                text_order = "Pedido6 Abuela";
                text_orderSummary = "ResumenAbuela6";
                break;

            case 7:
                text_order = "Pedido7 Abuela";
                text_orderSummary = "ResumenAbuela7";
                break;

            case 8:
                text_order = "Pedido8 Abuela";
                text_orderSummary = "ResumenAbuela8";
                break;

            case 9:
                text_order = "Pedido9 Abuela";
                text_orderSummary = "ResumenAbuela9";
                break;

            case 10:
                text_order = "Pedido10 Abuela";
                text_orderSummary = "ResumenAbuela10";
                break;
        }

        Order.text = text_order;
        Summary.text = text_orderSummary;
    }

    #endregion
    /*
    #region Variables

    //Variables flores
    int typeOfFlower;
    int color;
    int feeling;

    //Variables textos
    private string text_typeOfFlower;
    private string text_color;
    private string text_feeling;

    public TMP_Text Type;
    public TMP_Text Color;
    public TMP_Text Feeling;

    #endregion


    #region Awake

    private void Awake()
    {
        typeOfFlower = Random.Range(1, 11);
        color = Random.Range(1, 11);
        feeling = Random.Range(1, 11);


        FlowersType(typeOfFlower);
        FlowersColor(color);
        Feelings(feeling);
    }

    #endregion


    #region FuncionesPedidosFlores
    private void FlowersType(int typeOfFlower)
    {
        switch (typeOfFlower)
        {
            case 1:
                text_typeOfFlower = "Tipo1";
                break;

            case 2:
                text_typeOfFlower = "Tipo2";
                break;

            case 3:
                text_typeOfFlower = "Tipo3";
                break;

            case 4:
                text_typeOfFlower = "Tipo4";
                break;

            case 5:
                text_typeOfFlower = "Tipo5";
                break;

            case 6:
                text_typeOfFlower = "Tipo6";
                break;

            case 7:
                text_typeOfFlower = "Tipo7";
                break;

            case 8:
                text_typeOfFlower = "Tipo8";
                break;

            case 9:
                text_typeOfFlower = "Tipo9";
                break;

            case 10:
                text_typeOfFlower = "Tipo10";
                break;

        }
        Type.text = text_typeOfFlower;
    }

    private void FlowersColor(int color)
    {
        switch (color)
        {
            case 1:
                text_color = "Color1";
                break;

            case 2:
                text_color = "Color2";
                break;

            case 3:
                text_color = "Color3";
                break;

            case 4:
                text_color = "Color4";
                break;

            case 5:
                text_color = "Color5";
                break;

            case 6:
                text_color = "Color6";
                break;

            case 7:
                text_color = "Color7";
                break;

            case 8:
                text_color = "Color8";
                break;

            case 9:
                text_color = "Color9";
                break;

            case 10:
                text_color = "Color10";
                break;

        }

        Color.text = text_color;
    }

    private void Feelings(int feeling)
    {
        switch (feeling)
        {
            case 1:
                text_feeling = "Sentimiento1";
                break;

            case 2:
                text_feeling = "Sentimiento2";
                break;

            case 3:
                text_feeling = "Sentimiento3";
                break;

            case 4:
                text_feeling = "Sentimiento4";
                break;

            case 5:
                text_feeling = "Sentimiento5";
                break;

            case 6:
                text_feeling = "Sentimiento6";
                break;

            case 7:
                text_feeling = "Sentimiento7";
                break;

            case 8:
                text_feeling = "Sentimiento8";
                break;

            case 9:
                text_feeling = "Sentimiento9";
                break;

            case 10:
                text_feeling = "Sentimiento10";
                break;
        }

        Feeling.text = text_feeling;
    }
    #endregion
    */


}
