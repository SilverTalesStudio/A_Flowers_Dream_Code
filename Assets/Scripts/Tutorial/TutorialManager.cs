using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    private int n = 0;
    public GameObject ButtonBack;
    public GameObject CursorClick;
    public GameObject CursorMove;
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject T5;
    public GameObject T6;
    public GameObject T7;
    public GameObject T8;
    public GameObject T9;
    public GameObject T10;
    public GameObject T1Text1;
    public GameObject T1Text2;
    public GameObject T2Text1;
    public GameObject T2Text2;
    public GameObject T2Text3;
    public GameObject T2Text4;
    public GameObject T2Text5;
    public GameObject T6Text1;
    public GameObject T6Text2;
    public GameObject T7Text1;
    public GameObject T7Text2;
    public GameObject T9Text1;
    public GameObject T9Text2;
    public GameObject T10Text1;
    public GameObject T10Text2;
    public GameObject T10Text3;

    public void OpenTutorial()
    {
        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if (f.name != "FlowerBase")
                f.GetComponent<DragAndDrop>().enableClick = false;
        }
        n = 0;
        CursorClick.SetActive(false);
        CursorMove.SetActive(false);
        ButtonBack.SetActive(false);
        T1.SetActive(true);
        T2.SetActive(false);
        T3.SetActive(false);
        T4.SetActive(false);
        T5.SetActive(false);
        T6.SetActive(false);
        T7.SetActive(false);
        T8.SetActive(false);
        T9.SetActive(false);
        T10.SetActive(false);
        T1Text1.SetActive(true);
        T1Text2.SetActive(false);
        T2Text1.SetActive(true);
        T2Text2.SetActive(false);
        T2Text3.SetActive(false);
        T2Text4.SetActive(false);
        T2Text5.SetActive(false);
        T6Text1.SetActive(true);
        T6Text2.SetActive(false);
        T7Text1.SetActive(true);
        T7Text2.SetActive(false);
        T9Text1.SetActive(true);
        T9Text2.SetActive(false);
        T10Text1.SetActive(true);
        T10Text2.SetActive(false);
        T10Text3.SetActive(false);
        gameObject.SetActive(true);
    }

    public void CloseTutorial()
    {
        foreach (GameObject f in GameObject.FindGameObjectsWithTag("Flores"))
        {
            if (f.name != "FlowerBase")
                f.GetComponent<DragAndDrop>().enableClick = true;
        }
        gameObject.SetActive(false);
    }
    public void Next()
    {
        if(n > 19)
        {
            n = 19;
        }
        else
        {
            n++;
        }
        

        switch (n)
        {
            case 1:
                ButtonBack.SetActive(true);
                CursorClick.transform.position = new Vector3(0.11f, -4.90f, 0);
                CursorClick.SetActive(true);
                T1Text1.SetActive(false);
                T1Text2.SetActive(true);
                break;
            case 2:
                CursorClick.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(true);
                break;
            case 3:
                T2Text1.SetActive(false);
                T2Text2.SetActive(true);
                CursorClick.transform.position = new Vector3(0.91f, 0.31f, 0);
                CursorClick.SetActive(true);
                break;
            case 4:
                T2Text2.SetActive(false);
                T2Text3.SetActive(true);
                CursorClick.transform.position = new Vector3(-6.3f, 6.21f, 0);
                break;
            case 5:
                T2Text3.SetActive(false);
                T2Text4.SetActive(true);
                CursorClick.transform.position = new Vector3(-10.6f, -0.68f, 0);
                break;
            case 6:
                T2Text4.SetActive(false);
                T2Text5.SetActive(true);
                CursorClick.transform.position = new Vector3(13.16f, 0.58f, 0);
                break;
            case 7:
                CursorClick.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(true);
                CursorClick.SetActive(false);
                break;
            case 8:
                T3.SetActive(false);
                T4.SetActive(true);
                CursorMove.SetActive(true);
                CursorMove.GetComponent<Animator>().Play("CursorMove");
                break;
            case 9:
                CursorMove.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(true);
                CursorClick.transform.position = new Vector3(11.52f, -2.02f, 0);
                CursorClick.SetActive(true);              
                break;
            case 10:
                CursorClick.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(true);
                CursorMove.SetActive(true);
                CursorMove.GetComponent<Animator>().Play("CursorArrastrar");
                break;
            case 11:
                CursorMove.SetActive(false);
                T6Text1.SetActive(false);
                T6Text2.SetActive(true);
                CursorClick.transform.position = new Vector3(-8.20f, 3.63f, 0);
                CursorClick.SetActive(true);
                break;
            case 12:
                CursorClick.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(true);
                break;
            case 13:
                T7Text1.SetActive(false);
                T7Text2.SetActive(true);
                break;
            case 14:
                T7.SetActive(false);
                T8.SetActive(true);
                CursorClick.transform.position = new Vector3(-8.09f, -5.34f, 0);
                CursorClick.SetActive(true);
                break;
            case 15:
                CursorClick.SetActive(false);
                T8.SetActive(false);
                T9.SetActive(true);
                break;
            case 16:
                T9Text1.SetActive(false);
                T9Text2.SetActive(true);
                break;
            case 17:
                T9.SetActive(false);
                T10.SetActive(true);
                break;
            case 18:
                T10Text1.SetActive(false);
                T10Text2.SetActive(true);
                break;
            case 19:
                T10Text2.SetActive(false);
                T10Text3.SetActive(true);
                break;
            case 20:
                gameObject.SetActive(false);
                break;
        }
    }
    public void Back()
    {
        if (n < 0)
        {
            n = 0;
        }
        else
        {
            n--;
        }
        
        switch (n)
        {
            case 0:
                ButtonBack.SetActive(false);
                CursorClick.SetActive(!true);
                T1Text1.SetActive(!false);
                T1Text2.SetActive(!true);
                break;
            case 1:
                CursorClick.transform.position = new Vector3(0.11f, -4.90f, 0);
                CursorClick.SetActive(!false);
                T1.SetActive(!false);
                T2.SetActive(!true);
                break;
            case 2:
                T2Text1.SetActive(!false);
                T2Text2.SetActive(!true);
                
                CursorClick.SetActive(!true);
                break;
            case 3:
                CursorClick.transform.position = new Vector3(0.91f, 0.31f, 0);
                T2Text2.SetActive(!false);
                T2Text3.SetActive(!true);
                
                break;
            case 4:
                CursorClick.transform.position = new Vector3(-6.3f, 6.21f, 0);
                T2Text3.SetActive(!false);
                T2Text4.SetActive(!true);
                
                break;
            case 5:
                CursorClick.transform.position = new Vector3(-10.6f, -0.68f, 0);
                T2Text4.SetActive(!false);
                T2Text5.SetActive(!true);                
                break;
            case 6:
                CursorClick.transform.position = new Vector3(13.16f, 0.58f, 0);
                CursorClick.SetActive(!false);
                T2.SetActive(!false);
                T3.SetActive(!true);
                break;
            case 7:
                T3.SetActive(!false);
                T4.SetActive(!true);
                CursorMove.SetActive(!true);                
                break;
            case 8:                
                CursorMove.SetActive(!false);
                CursorMove.GetComponent<Animator>().Play("CursorMove");
                T4.SetActive(!false);
                T5.SetActive(!true);                
                CursorClick.SetActive(!true);
                break;
            case 9:
                CursorClick.transform.position = new Vector3(11.52f, -2.02f, 0);
                CursorClick.SetActive(!false);
                T5.SetActive(!false);
                T6.SetActive(!true);
                CursorMove.SetActive(!true);               
                break;
            case 10:
                CursorMove.SetActive(!false);
                CursorMove.GetComponent<Animator>().Play("CursorArrastrar");
                T6Text1.SetActive(!false);
                T6Text2.SetActive(!true);               
                CursorClick.SetActive(!true);
                break;
            case 11:
                CursorClick.transform.position = new Vector3(-8.20f, 3.63f, 0);
                CursorClick.SetActive(!false);
                T6.SetActive(!false);
                T7.SetActive(!true);
                break;
            case 12:
                T7Text1.SetActive(!false);
                T7Text2.SetActive(!true);
                break;
            case 13:
                T7.SetActive(!false);
                T8.SetActive(!true);                
                CursorClick.SetActive(!true);
                break;
            case 14:
                CursorClick.transform.position = new Vector3(-8.09f, -5.34f, 0);
                CursorClick.SetActive(!false);
                T8.SetActive(!false);
                T9.SetActive(!true);
                break;
            case 15:
                T9Text1.SetActive(!false);
                T9Text2.SetActive(!true);
                break;
            case 16:
                T9.SetActive(!false);
                T10.SetActive(!true);
                break;
            case 17:
                T10Text1.SetActive(!false);
                T10Text2.SetActive(!true);
                break;
            case 18:
                T10Text2.SetActive(!false);
                T10Text3.SetActive(!true);
                break;
        }
    }
}
