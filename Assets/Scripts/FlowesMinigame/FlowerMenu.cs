using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FlowerMenu : MonoBehaviour
{
    [SerializeField] private Animator animator;

    //Esta función es llamada al final de la animación "Clicked"
    //Al abrir el menú se cambia el texto o sprite del botón de abrir y cerrar la lista de flores
    public void OpenMenu()
    {
        if (GetComponent<SpriteRenderer>().flipX == false)
            GetComponent<SpriteRenderer>().flipX = true;
    }

    //Esta función es llamada al final de la animación "CloseClick"
    //Al cerrar el menú se cambia el texto o sprite del botón de abrir y cerrar la lista de flores
    public void CloseMenu()
    {
        if (GetComponent<SpriteRenderer>().flipX == true)
            GetComponent<SpriteRenderer>().flipX = false;
    }

    //Al pulsar el botón
    private void OnMouseDown()
    {
        //Si está cerrada la lista de flores, se activa la animación para abrirla
        if (GetComponent<SpriteRenderer>().flipX == false)
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

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

}
