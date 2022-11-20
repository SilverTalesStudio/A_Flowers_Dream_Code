using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FlowerMenu : MonoBehaviour
{
    public GameObject FlowersList;
    public GameObject ButtonSound;

    [SerializeField] private Animator animator;

    //Esta funci�n es llamada al final de la animaci�n "Clicked"
    //Al abrir el men� se cambia el texto o sprite del bot�n de abrir y cerrar la lista de flores
    public void OpenMenu()
    {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("boton_flip");            
    }

    //Esta funci�n es llamada al final de la animaci�n "CloseClick"
    //Al cerrar el men� se cambia el texto o sprite del bot�n de abrir y cerrar la lista de flores
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

    //Al pulsar el bot�n
    private void OnMouseDown()
    {
        ButtonSound.GetComponent<AudioSource>().Play();
        //Si est� cerrada la lista de flores, se activa la animaci�n para abrirla
        if (GetComponent<Image>().sprite.name == "boton")
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
        GetComponent<Image>().color = Color.gray;
    }

    private void OnMouseExit()
    {
        GetComponent<Image>().color = Color.white;
    }

}
