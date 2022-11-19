using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FlowerMenu : MonoBehaviour
{
    public GameObject FlowersList;

    [SerializeField] private Animator animator;

    //Esta función es llamada al final de la animación "Clicked"
    //Al abrir el menú se cambia el texto o sprite del botón de abrir y cerrar la lista de flores
    public void OpenMenu()
    {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("boton_flip");            
    }

    //Esta función es llamada al final de la animación "CloseClick"
    //Al cerrar el menú se cambia el texto o sprite del botón de abrir y cerrar la lista de flores
    public void CloseMenu()
    {
        GetComponent<Image>().sprite = Resources.Load<Sprite>("boton");
    }

    public void ShowFlowers()
    {
        foreach (Image s in FlowersList.GetComponentsInChildren<Image>())
        {
            s.enabled = true;
        }
    }
    public void HideFlowers()
    {
        foreach (SpriteRenderer v in FlowersList.GetComponentsInChildren<SpriteRenderer>())
        {
            v.enabled = false;
        }
    }

    //Al pulsar el botón
    private void OnMouseDown()
    {
        //Si está cerrada la lista de flores, se activa la animación para abrirla
        if (GetComponent<Image>().sprite.name == "boton")
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
        GetComponent<Image>().color = Color.gray;
    }

    private void OnMouseExit()
    {
        GetComponent<Image>().color = Color.white;
    }

}
