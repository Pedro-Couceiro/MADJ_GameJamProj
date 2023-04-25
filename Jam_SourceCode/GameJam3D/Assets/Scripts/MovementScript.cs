using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    
    private Rigidbody _rb;
    private Animator _animator;

    private bool _jumpCommand;
    private bool _leftCommand;
    private bool _rightCommand;
    private bool _downCommand;
    private bool _upCommand;
    [SerializeField] private bool _isGrounded;
    private bool _jumpEnded;
    private bool _canJump;

    [Header("Valores")]
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpPower;
    private float _horizontalInput;
    private float _verticalInput;

    [SerializeField] private GameObject _groundTestLineStart;
    [SerializeField] private GameObject _groundTestLineEnd;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            _upCommand = true;
        }

        if(Input.GetKey(KeyCode.S))
        {
            _downCommand = true;
        }

        if(Input.GetKey(KeyCode.A))
        {
            _leftCommand = true;
        }

        if(Input.GetKey(KeyCode.D))
        {
            _rightCommand = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _jumpCommand = true;
        }

        //BasicMovement();
    }

    private void FixedUpdate()
    {
        _isGrounded = Physics2D.Linecast(_groundTestLineEnd.transform.position, _groundTestLineStart.transform.position);

        if(_isGrounded)
        {
            _canJump = true;
        }

        if(_upCommand)
        {
            _rb.velocity = Vector3.forward * Time.deltaTime * _moveSpeed;
            transform.Translate(_rb.velocity);
            _upCommand = false;
        }

        if(_downCommand)
        {
            _rb.velocity = Vector3.back * Time.deltaTime * _moveSpeed;
            transform.Translate(_rb.velocity);
            _downCommand = false;
        }

        if(_leftCommand)
        {
            _rb.velocity = Vector3.left * Time.deltaTime * _moveSpeed;
            transform.Translate(_rb.velocity);
            _leftCommand = false;
        }

        if(_rightCommand)
        {
            _rb.velocity = Vector3.right * Time.deltaTime * _moveSpeed;
            transform.Translate(_rb.velocity);
            _rightCommand = false;
        }

        if(_jumpCommand)
        {
            _rb.velocity = Vector3.up * Time.deltaTime * _jumpPower;
            transform.Translate(_rb.velocity);
            _jumpCommand = false;
          
        }
    }

    /*public void BasicMovement()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * _moveSpeed * _verticalInput);
        transform.Translate(Vector3.right * _horizontalInput * _moveSpeed * Time.deltaTime);
    }*/
}
