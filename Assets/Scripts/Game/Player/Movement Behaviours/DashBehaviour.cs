using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashBehaviour : MonoBehaviour
{
    CharacterController controller;

    [SerializeField] private float dashDistance = 0.3f;
    [SerializeField] private float dashSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Dash();
    }

    private void Dash()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(DashCoroutine());
        }
    }

    private IEnumerator DashCoroutine()
    {
        Debug.Log("Dash");
        float startTime = Time.time; // need to remember this to know how long to dash
        while (Time.time < startTime + dashDistance)
        {
            controller.Move(transform.forward * dashSpeed * Time.deltaTime);
            yield return null; // this will make Unity stop here and continue next frame
        }
    }
}
