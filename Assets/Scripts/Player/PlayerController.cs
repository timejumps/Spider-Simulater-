using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpHeight;

    private Rigidbody _rigidbody;
    private float _vertical;
    private float _horizontal;
    public bool isGrounded;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        _vertical = Input.GetAxisRaw("Vertical");
        _horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, _jumpHeight, 0));
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * _vertical * _speed);
        _rigidbody.AddForce(transform.right * _horizontal * _speed);
    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
