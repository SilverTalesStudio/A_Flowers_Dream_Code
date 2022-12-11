using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSettingsKeep : MonoBehaviour
{
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private float backgroundFloat, soundEffectsFloat;
    AudioSource backgroundAudio;
    public AudioSource soundEffectsAudio;
    void Awake()
    {
        backgroundAudio = GameObject.Find("MusicAudioSource").GetComponent<AudioSource>();
        backgroundFloat = PlayerPrefs.GetFloat(BackgroundPref);
        backgroundAudio.volume = backgroundFloat;
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);
        soundEffectsAudio.volume = soundEffectsFloat;
    }
}
