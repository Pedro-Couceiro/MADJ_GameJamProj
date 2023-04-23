using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private Rigidbody _rb;
    private Animator _animator;

    [SerializeField] private bool _isGrounded;
    private bool _canJump;

    [Header("Valores")]
    [SerializeField] private float _moveSpeed;
    private float _horizontalInput;
    private float _verticalInput;

    void Start()
    {
        
    }

    void Update()
    {
        BasicMovement();
    }

    public void BasicMovement()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * _moveSpeed * _verticalInput);
        transform.Translate(Vector3.right * _horizontalInput * _moveSpeed * Time.deltaTime);
    }
}
