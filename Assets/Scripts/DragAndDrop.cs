using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 startPosition;
    private Quaternion startRotation;
    private Vector3 startScale;
    private Vector3 mousePos;
    private bool clicked;
    public Collider2D flowerCol;
    public Collider2D ramoCol;
    
    private void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        startScale = transform.localScale;
    }

    private void OnMouseDrag()
    {
             
        //mover objeto en pantalla
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y,transform.position.z);
        
    }

    private void OnMouseDown()
    {      
        transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, 0, 0);
        transform.localScale = new Vector3(2, 2, 2);
        
    }
    private void OnMouseUp()
    {
        if (!(Physics2D.IsTouching(flowerCol, ramoCol))){
            transform.position = startPosition;
            transform.rotation = startRotation;
            transform.localScale = startScale;
        }
        
    }

            
        
}

