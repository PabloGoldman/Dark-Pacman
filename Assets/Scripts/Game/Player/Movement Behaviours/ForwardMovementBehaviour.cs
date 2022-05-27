using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovementBehaviour : MonoBehaviour
{
    PlayerComponents playerComp;
    [SerializeField] private float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        playerComp = GetComponent<PlayerComponents>();
    }

    // Update is called once per frame
    void Update()
    {
        ForwardMovement();
    }

    void ForwardMovement()
    {
        playerComp.moveDirection = new Vector3(0, playerComp.moveDirection.y, speed * Input.GetAxisRaw("Vertical"));
    }
}
