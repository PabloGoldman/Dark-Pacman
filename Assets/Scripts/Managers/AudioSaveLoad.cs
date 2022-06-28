using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSaveLoad : MonoBehaviour, ILoaderSaver
{
    const string musicKey = "musicVolume";
    const string sfxKey = "sxfVolume";


    public void GetVolume(out float musicVolume, out float sfxVolume)
    {
        if (PlayerPrefs.HasKey(musicKey))
        {
            musicVolume = PlayerPrefs.GetFloat(musicKey);
            sfxVolume = PlayerPrefs.GetFloat(sfxKey);
        }
        else
        {
            musicVolume = .5f;
            sfxVolume = .5f;
        }
    }

    public void SetVolume(float music, float sfx)
    {
        PlayerPrefs.SetFloat(musicKey, music);
        PlayerPrefs.SetFloat(sfxKey, sfx);
    }
}
