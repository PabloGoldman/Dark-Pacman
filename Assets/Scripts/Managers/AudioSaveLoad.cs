using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSaveLoad : MonoBehaviour
{
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    const string musicVol = "musicVolume";
    const string sfxVol = "sxfVolume";

    private void Awake()
    {
        if (PlayerPrefs.HasKey(musicVol))
        {
            musicSlider.value = PlayerPrefs.GetFloat(musicVol);
        }
        else
        {
            musicSlider.value = 0.5f;
        }

        if (PlayerPrefs.HasKey(sfxVol))
        {
            sfxSlider.value = PlayerPrefs.GetFloat(sfxVol);
        }
        else
        {
            sfxSlider.value = 0.5f;
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value);
        PlayerPrefs.SetFloat("sxfVolume", sfxSlider.value);
    }
}
