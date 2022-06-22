using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallCollision : MonoBehaviour
{
    public UnityEvent OnBallCollision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            other.gameObject.SetActive(false);
            OnBallCollision?.Invoke();
        }
    }
}
