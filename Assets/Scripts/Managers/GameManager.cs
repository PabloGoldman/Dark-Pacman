using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    bool gameOver = false;

    [SerializeField] GameObject lossGamePanel;

    void Update()
    {
        //Este codigo tendria que ir aca?
        if (gameOver && Input.anyKey)
        {
            ResetGame();
        }
    }

    public void ResetGame()
    {
        //Aca o en el scene manager?
        SetTimeScale(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetTimeScale(int scale)
    {
        Time.timeScale = scale;
    }

    public void LoseGame()
    {
        //Esta funcion esté en el canvas o en el game manager?
        gameOver = true;
        lossGamePanel.SetActive(true);
        SetTimeScale(0);
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
