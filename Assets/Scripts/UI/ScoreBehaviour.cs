using TMPro;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    TMP_Text textField;

    int score = 0;

    void Start()
    {
        textField = GetComponent<TMP_Text>();
    }

    public void AddScore()
    {
        score++;
        textField.text = score + "/" + GameManager.Get().levelSettings.ballsToWin;
    }
}
