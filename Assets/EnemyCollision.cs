using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyCollision : MonoBehaviour
{
    public UnityEvent OnEnemyCollision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SetActive(false);
            OnEnemyCollision?.Invoke();
        }
    }
}
