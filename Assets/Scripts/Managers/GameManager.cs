using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    bool gameOver = false;
    bool winGame = false;

    [SerializeField] GameObject lossGamePanel;
    [SerializeField] GameObject winGamePanel;

    public LevelSettings levelSettings;

    public int playerScore;

    void Update()
    {
        if (playerScore >= levelSettings.ballsToWin)
        {
            WinGame();
        }

        if ((gameOver || winGame) && Input.anyKeyDown)
        {
            ResetGame();
        }
    }

    public void AddScore()
    {
        playerScore++;
    }

    public void ResetGame()
    {
        SetTimeScale(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetTimeScale(int scale)
    {
        Time.timeScale = scale;
    }

    public void LoseGame()
    {
        gameOver = true;
        lossGamePanel.SetActive(true);
        SetTimeScale(0);
    }

    public void WinGame()
    {
        winGame = true;
        winGamePanel.SetActive(true);
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
