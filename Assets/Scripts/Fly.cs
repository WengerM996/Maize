using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Fly : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();

        Action();
    }

    private void Action()
    {
        _rigidBody.AddForce(transform.forward * _speed, ForceMode.Impulse);
    }
}
