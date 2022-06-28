using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SlidersBehaviours : MonoBehaviour
{
    const string musicVol = "musicVolume";
    const string sfxVol = "sxfVolume";

    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    public UnityEvent<float, float> onQuit; 

    void Start()
    {
        if (PlayerPrefs.HasKey(musicVol))
        {
            musicSlider.value = PlayerPrefs.GetFloat(musicVol);
            sfxSlider.value = PlayerPrefs.GetFloat(sfxVol);
        }
        else
        {
            musicSlider.value = 0.5f;
            sfxSlider.value = 0.5f;
        }
    }

    private void OnApplicationQuit()
    {
        onQuit.Invoke(musicSlider.value, sfxSlider.value);
    }
}
