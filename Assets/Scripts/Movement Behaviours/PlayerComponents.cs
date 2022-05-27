using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerComponents : MonoBehaviour
{
    [HideInInspector] public CharacterController controller;

    public float gravityValue = 35f;

    [SerializeField] LayerMask groundLayer;

    [HideInInspector] public Vector3 moveDirection = Vector3.zero;

    [HideInInspector] public bool isGrounded;
    public bool GetIsGrounded() => isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIsGrounded();

        moveDirection = transform.TransformDirection(moveDirection);
        controller.Move(moveDirection * Time.deltaTime);
    }

    void CheckIsGrounded()
    {
        isGrounded = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1.5f, groundLayer);
    }
}
