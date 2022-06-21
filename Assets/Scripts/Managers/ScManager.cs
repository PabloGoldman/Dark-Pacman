using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScManager : MonoBehaviour
{
    public void LoadScene(int num)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(num);
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
