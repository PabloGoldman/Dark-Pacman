using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{
    PlayerComponents playerComp;
    
    [SerializeField] private float jumpHeight = 6;

    float jump;

    private void Start()
    {
        playerComp = GetComponent<PlayerComponents>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        playerComp.moveDirection = new Vector3(0, jump, playerComp.moveDirection.z);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && playerComp.GetIsGrounded())
        {
            jump = jumpHeight;
        }

        if (!playerComp.GetIsGrounded())
        {
            jump -= playerComp.gravityValue * Time.deltaTime;
        }
    }
}
