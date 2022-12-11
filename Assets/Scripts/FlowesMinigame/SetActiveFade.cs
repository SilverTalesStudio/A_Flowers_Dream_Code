using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveFade : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Animator>().Play("FadeIn");
    }
    public void DeactivateFade()
    {
        gameObject.SetActive(false);
    }
    
}
