using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    public Collider2D flowerCol;
    public Collider2D ramoCol;
    public Transform FlowersList;
    public GameObject panel;
    public GameObject Flist;
    public GameObject FlowersManager;
    public GameObject FlowerBase;
    public string fname;
    public string fcolor;
    public string ffeeling;
    public string fav;
    public string hate;
    public float fTotalColor;
    public float fTotalFeeling;
    public bool enableClick = true;
    private Quaternion startRotation;
    private Vector3 startScale;
    private Vector3 mousePos;
    private GameObject resetPos;

    private void Awake()
    {
        ramoCol = GameObject.Find("Bouquet").GetComponent<BoxCollider2D>();
        FlowersList = GameObject.Find("FlowersList").GetComponent<Transform>();
        panel = GameObject.Find("FlowersPanel");
        Flist = GameObject.Find("FlowersList");
        FlowersManager = GameObject.Find("FlowersManager");
        FlowerBase = GameObject.Find("FlowerBase");
        gameObject.transform.SetParent(FlowersList);
        transform.localScale = FlowerBase.transform.localScale;
        gameObject.AddComponent<PolygonCollider2D>();
        flowerCol = GetComponent<PolygonCollider2D>();
    }

    private void Start()
    {
        //Resetea la posición de la flor:

        //Se crea objeto solo con componente transform que almacena la posición inicial de la flor (El transform peta si no hago esto)
        
        resetPos = new GameObject();
        resetPos.transform.SetParent(FlowersList);
        resetPos.transform.position = transform.position;
        startRotation = transform.rotation;
        startScale = transform.localScale;
        GetComponent<Image>().enabled = false;
    }

    private void OnMouseDrag()
    {
        if (enableClick)
        {
            //Mueve la flor seleccionada con el ratón    
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
        }
            
 
    }

    private void OnMouseDown()
    {
        if(enableClick)
        {
            //Desactiva el scroll de la lista de flores
            panel.GetComponent<ScrollRect>().enabled = false;

            //La flor deja de pertenecer a la lista de flores para poder hacer transformaciones globales sin dependencias
            transform.SetParent(GameObject.Find("MiniGameManager").transform);

            //Agranda la flor para colocarla en el ramo
            GetComponent<RectTransform>().eulerAngles = new Vector3(0, 0, 0);
            transform.localScale = new Vector3(50f, 50f, 50f);
        }       
    }
    private void OnMouseUp()
    {
        if (enableClick)
        {
            //Activa el scroll de la lista de flores al soltar la flor
            panel.GetComponent<ScrollRect>().enabled = true;

            //Si la flor no está dentro del ramo
            if (!(Physics2D.IsTouching(flowerCol, ramoCol)))
            {
                if (FlowersManager.GetComponent<FlowersManager>()._flowersInBouquet.Contains(gameObject.name))
                {
                    FlowersManager.GetComponent<FlowersManager>().DeleteFlowers(gameObject.name);
                }

                //vuelve a pertenecer a la lista de flores y tiene transformaciones con dependencias
                transform.SetParent(FlowersList);

                //Resetea la posición de la flor con los valores iniciales en la lista de flores
                transform.position = resetPos.transform.position;
                transform.rotation = startRotation;
                transform.localScale = startScale;

            }
            else
            {
                if (!FlowersManager.GetComponent<FlowersManager>()._flowersInBouquet.Contains(gameObject.name))
                {
                    FlowersManager.GetComponent<FlowersManager>().AddFlowers(gameObject.name);
                }
            }
        }

     }
      
}

