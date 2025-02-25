using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponionMovement : MonoBehaviour
{

    [SerializeField] private Transform _followTarger;
    [SerializeField] private Transform _lookTarger;
    [SerializeField] private float _lenghtRay;
    [SerializeField] private Vector3 _offset;

    private float _speed = 1;

    void Start()
    {
        _offset = transform.position - _followTarger.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _followTarger.position + _offset;
        transform.RotateAround(_followTarger.position, Vector3.forward, _speed);
        transform.LookAt(_lookTarger.position);
        _offset = transform.position - _followTarger.position;
        Debug.DrawRay(transform.position, transform.forward * _lenghtRay, Color.red);
    }
}
