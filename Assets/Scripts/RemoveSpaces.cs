using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class RemoveSpaces : MonoBehaviour
{
    public TMP_InputField inputField;

    void Start()
    {
        inputField.onValueChanged.AddListener(delegate { RemoveSpace(); });
    }

    void RemoveSpace()
    {
        inputField.text = inputField.text.Replace(" ", "");
    }
}
