using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SlidersBehaviours : MonoBehaviour
{
    [SerializeField] ILoaderSaver loaderSaver;

    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    public UnityEvent<float, float> onQuit;

    void Start()
    {
        float music;
        float sfx;

        loaderSaver.GetVolume(out music, out sfx);

        musicSlider.value = music;

        sfxSlider.value = sfx;

    }

    private void OnApplicationQuit()
    {
        onQuit.Invoke(musicSlider.value, sfxSlider.value);
    }
}
