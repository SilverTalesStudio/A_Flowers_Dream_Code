using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Yarn.Unity.Example;

public class AudioSettings : MonoBehaviour
{
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private float backgroundFloat, soundEffectsFloat;
    AudioSource backgroundAudio;
    public AudioSource soundEffectsAudio;
    public Slider backgroundSlider, soundEffectsSlider;
    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        if (SceneManager.GetActiveScene().name != "VisualNovel")
        {
            backgroundAudio = GameObject.Find("MusicAudioSource").GetComponent<AudioSource>();            
            backgroundAudio.volume = backgroundFloat;
            
        }
        else
        {
            foreach (AudioSource a in GameObject.Find("Visual Novel Manager").GetComponent<VNManager>().sounds)
            {
                a.volume = soundEffectsFloat;
            }
        }
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        backgroundSlider.value = backgroundFloat;
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
        soundEffectsAudio.volume = soundEffectsFloat;
        soundEffectsSlider.value = soundEffectsFloat;
    }

    public void SaveSoundSettings()
    {
            PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsSlider.value);      
    }

    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        if(SceneManager.GetActiveScene().name == "VisualNovel")
        {
            foreach(AudioSource a in GameObject.Find("Visual Novel Manager").GetComponent<VNManager>().sounds)
            {
                a.volume = backgroundSlider.value;
            }
        }
        else
        {
            backgroundAudio.volume = backgroundSlider.value;
        }        
        soundEffectsAudio.volume = soundEffectsSlider.value;
    }
}
