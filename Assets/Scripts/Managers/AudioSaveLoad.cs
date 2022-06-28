using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSaveLoad : MonoBehaviour
{
    const string musicVol = "musicVolume";
    const string sfxVol = "sxfVolume";

    public void SetVolume(float music, float sfx)
    {
        PlayerPrefs.SetFloat(musicVol, music);
        PlayerPrefs.SetFloat(sfxVol, sfx);
    }
}
