using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FlowerMenu : MonoBehaviour
{
    public GameObject Text;
    [SerializeField] private Animator animator;

    //Esta función es llamada al final de la animación "Clicked"
    //Al abrir el menú se cambia el texto o sprite del botón de abrir y cerrar la lista de flores
    public void OpenMenu()
    {
        Text.GetComponent<TextMeshPro>().text = ">";
    }

    //Esta función es llamada al final de la animación "CloseClick"
    //Al cerrar el menú se cambia el texto o sprite del botón de abrir y cerrar la lista de flores
    public void CloseMenu()
    {
         Text.GetComponent<TextMeshPro>().text = "<";
    }

    //Al pulsar el botón
    private void OnMouseDown()
    {
        //Si está cerrada la lista de flores, se activa la animación para abrirla
        if (Text.GetComponent<TextMeshPro>().text == "<")
        {
            animator.GetComponent<Animator>().Play("Clicked");
        }

        //Si está abierta la lista de flores, se activa la animación para cerrarla
        else
        {
            animator.GetComponent<Animator>().Play("CloseClick");
        }
    }

    //Cambio de color al poner el ratón encima del botón
    private void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }


}
