using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void playVN()
    {
        SceneManager.LoadScene("VisualNovel");
    }



    //Cambio de escena genérico
    public void changeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }


}
