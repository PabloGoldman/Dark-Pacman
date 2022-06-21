using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviourSingleton<AudioManager>
{
    [SerializeField] List<AudioSource> gameAudios;
    [SerializeField] List<AudioSource> gameSounds;

    public void PlayBallSound()
    {
        gameSounds[0].Play();
    }
}
