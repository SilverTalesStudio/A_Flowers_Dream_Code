using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Orders_Manager : MonoBehaviour
{
    #region variables

    //Variable del pedido
    int order;

    //Variable del texto
    private string text_order;
    private string text_orderSummary;

    public TMP_Text Order;
    public TMP_Text Summary;

    #endregion

    #region Awake
    private void Awake()
    {
        order = Random.Range(1, 11);
        CustomOrder(order);
    }
    #endregion

    #region Funciones
    private void CustomOrder(int order)
    {
        order = 1;
        switch (order)
        {
            case 1:
                text_order = "Pedido1 askhnaibasbdsbdsadbsdasdjsadjsadsjadjasdjasdjsajdjsjdjjsjjdjsjdjasjdjjsadjjsajdjsajdjsajdjasdsjadjasjdjasjdjqhwqkwhlqhwlajkhkahdkasfhdlsrfegvhdsifhdsfkasfsafhaskfhaskfhakshgashdkhgsdkghsdkhgsdhgksdghksdhgksdhkghsdkghkdshgksdhgksdhgksdhgksdhkghksdhgskdghsk";
                text_orderSummary = "Resumen1";
                break;

            case 2:
                text_order = "Pedido2 aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                text_orderSummary = "Resumen2";
                break;

            case 3:
                text_order = "Pedido3";
                text_orderSummary = "Resumen3";
                break;

            case 4:
                text_order = "Pedido4";
                text_orderSummary = "Resumen4";
                break;

            case 5:
                text_order = "Pedido5";
                text_orderSummary = "Resumen5";
                break;

            case 6:
                text_order = "Pedido6";
                text_orderSummary = "Resumen6";
                break;

            case 7:
                text_order = "Pedido7";
                text_orderSummary = "Resumen7";
                break;

            case 8:
                text_order = "Pedido8";
                text_orderSummary = "Resumen8";
                break;

            case 9:
                text_order = "Pedido9";
                text_orderSummary = "Resumen9";
                break;

            case 10:
                text_order = "Pedido10";
                text_orderSummary = "Resumen10";
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
