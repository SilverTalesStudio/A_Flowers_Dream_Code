using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirtsPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private int firstPlayInt;
    public Slider backgroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;
    AudioSource backgroundAudio;
    AudioSource soundEffectsAudio;

    void Awake()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirtsPlay);
        backgroundAudio = GameObject.Find("MusicAudioSource").GetComponent<AudioSource>();
        soundEffectsAudio = GameObject.Find("ButtonAudioSource").GetComponent<AudioSource>();
        if (firstPlayInt == 0)
        {
            backgroundFloat = .4f;
            soundEffectsFloat = 1f;
            backgroundSlider.value = backgroundFloat;
            soundEffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(SoundEffectsPref, soundEffectsFloat);
            PlayerPrefs.SetInt(FirtsPlay, -1);
        }
        else
        {
            backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
            backgroundAudio.volume = backgroundFloat;
            backgroundSlider.value = backgroundFloat;
            soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
            soundEffectsAudio.volume = soundEffectsFloat;
            soundEffectsSlider.value = soundEffectsFloat;

        }
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
        backgroundAudio.volume = backgroundSlider.value;
        soundEffectsAudio.volume = soundEffectsSlider.value;
    }
}
