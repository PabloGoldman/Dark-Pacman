using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverBehaviour : MonoBehaviour
{
    bool gameOver = false;

    [SerializeField] GameObject lossGamePanel;

    void Update()
    {
        //Este codigo tendria que ir aca?
        if (gameOver && Input.anyKey)
        {
            GameManager.Get().ResetGame();
        }
    }

    public void LoseGame()
    {
        //Esta funcion esté en el canvas o en el game manager?
        gameOver = true;
        lossGamePanel.SetActive(true);
        GameManager.Get().SetTimeScale(0);
    }
}
