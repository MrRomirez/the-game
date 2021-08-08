using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Mower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Move(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.back);
        }
        //else if (Input.GetKey(KeyCode.Space))
        //{
        //    _rigidbody.AddForce(Vector3.up * _jumpForce);
            //Move(Vector3.up);
        //}
    }
    private void Move(Vector3 direction)
    {
        _rigidbody.AddForce(direction * _speed);
    }
}
