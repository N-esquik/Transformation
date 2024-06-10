using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private float _speedRotation = 35.0f;

    private Vector3 initialScale;

    private float _minSize = 1.0f;
    private float _maxSize = 1.5f;
    private float _amplitude = 1.0f;

    private void Start()
    {
        initialScale = transform.localScale;
    }

    private void Update()
    {
        Move();
        Rotate();
        increase();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * _speedRotation * Time.deltaTime);
    }

    private void increase()
    {
        float scale = Mathf.Lerp(_minSize, _maxSize, Mathf.PingPong(Time.time * _speed, _amplitude));

        transform.localScale = initialScale * scale;
    }
}
