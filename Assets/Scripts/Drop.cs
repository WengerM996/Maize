using System;
using UnityEngine;

public class Drop : MonoBehaviour
{
    [SerializeField] private GameObject _objectToDrop;
    [SerializeField] private Transform _dropPoint;
    [SerializeField] private float _delay;
    [SerializeField] private float _force;
    
    private float _counter;

    private void Update()
    {
        _counter += Time.deltaTime;

        if (_counter >= _delay)
        {
            _counter = 0;
            Out();
        }
    }

    private void Out()
    {
        var objectToDrop = Instantiate(_objectToDrop, _dropPoint.position, Quaternion.identity);
        
        if (objectToDrop.TryGetComponent(out Rigidbody rigidBody))
        {
            rigidBody.AddForce(Vector3.down * _force, ForceMode.Impulse);
        }
    }
}
