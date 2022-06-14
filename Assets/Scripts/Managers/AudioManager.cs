using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviourSingleton<AudioManager>
{
    [SerializeField] List<AudioSource> gameAudios;
    [SerializeField] List<AudioSource> gameSounds;

    public AudioMixer audioMixer;
    public AudioMixer SFXMixer;

    public void PlayBallSound()
    {
        //gameSounds[0].Play();
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
    }

    public void SetSFXVolume(float volume)
    {
        SFXMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
    }
}
