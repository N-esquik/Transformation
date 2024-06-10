using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSize : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private Vector3 _initialScale;

    private float _minSize = 1.0f;
    private float _maxSize = 2.0f;
    private float _amplitude = 1.0f;

    private void Start()
    {
        _initialScale = transform.localScale;
    }

    private void Update()
    {
        Increase();
    }

    private void Increase()
    {
        float scale = Mathf.Lerp(_minSize, _maxSize, Mathf.PingPong(Time.time / _speed, _amplitude));

        transform.localScale = _initialScale * scale;
    }
}
