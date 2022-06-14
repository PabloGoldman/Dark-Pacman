using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    [SerializeField] GameObject lossGamepanel;
    public void LoseGame()
    {
        //Esta funcion esté en el canvas o en el game manager?
        lossGamepanel.SetActive(true);
    }

    public void SetTimeScale(int scale)
    {
        Time.timeScale = scale;
    }

    public void ResetGame()
    {
        //Aca o en el scene manager?
        SetTimeScale(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
