using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePause : MonoBehaviour
{
    [SerializeField] GameObject inGamePause;
    [SerializeField] GameObject optionsMenu;

    bool inPause = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!inPause)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }
    
    public void Pause()
    {
        //Hacer que el timeScale lo cambie el game manager?
        GameManager.Get().SetTimeScale(0);
        inGamePause.SetActive(true);
        inPause = true;
    }

    public void Resume()
    {
        GameManager.Get().SetTimeScale(1);
        inGamePause.SetActive(false);
        optionsMenu.SetActive(false);
        inPause = false;
    }
}
