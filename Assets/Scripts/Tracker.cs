using System;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    [SerializeField] private float _cameraOffsetX;
    [SerializeField] private float _cameraOffsetY;
    [SerializeField] private float _cameraOffsetZ;

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        SetCamera();
    }

    private void SetCamera()
    {
        var position = transform.position;
        position.x += _cameraOffsetX;
        position.y += _cameraOffsetY;
        position.z += _cameraOffsetZ;
        _camera.transform.position = position;
        _camera.transform.LookAt(transform);
    }
}
