using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallCollision : MonoBehaviour
{
    public UnityEvent OnBallCollision;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            other.gameObject.SetActive(false);
            score++;
            OnBallCollision?.Invoke();
        }
    }
}
