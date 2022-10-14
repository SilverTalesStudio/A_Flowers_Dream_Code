using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FlowerMenu : MonoBehaviour
{
    public GameObject Text;
    [SerializeField] private Animator animator;

    //Esta funci�n es llamada al final de la animaci�n "Clicked"
    //Al abrir el men� se cambia el texto o sprite del bot�n de abrir y cerrar la lista de flores
    public void OpenMenu()
    {
        Text.GetComponent<TextMeshPro>().text = ">";
    }

    //Esta funci�n es llamada al final de la animaci�n "CloseClick"
    //Al cerrar el men� se cambia el texto o sprite del bot�n de abrir y cerrar la lista de flores
    public void CloseMenu()
    {
         Text.GetComponent<TextMeshPro>().text = "<";
    }

    //Al pulsar el bot�n
    private void OnMouseDown()
    {
        //Si est� cerrada la lista de flores, se activa la animaci�n para abrirla
        if (Text.GetComponent<TextMeshPro>().text == "<")
        {
            animator.GetComponent<Animator>().Play("Clicked");
        }

        //Si est� abierta la lista de flores, se activa la animaci�n para cerrarla
        else
        {
            animator.GetComponent<Animator>().Play("CloseClick");
        }
    }

    //Cambio de color al poner el rat�n encima del bot�n
    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
