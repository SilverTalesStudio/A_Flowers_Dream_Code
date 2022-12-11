using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
    public GameObject Setting;

    public void OpenSettings()
    {
        Setting.SetActive(true);
    }

    public void CloseSettings()
    {
        Setting.SetActive(false);
    }
}
