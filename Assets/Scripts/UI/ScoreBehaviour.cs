using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    TMP_Text textField;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        textField = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textField.text = score + "/" +  GameManager.Get().ballsToWin;
    }

    public void AddScore()
    {
        score++;
    }
}
