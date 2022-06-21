using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixer SFXMixer;

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
    }

    public void SetSFXVolume(float volume)
    {
        SFXMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
    }
}
