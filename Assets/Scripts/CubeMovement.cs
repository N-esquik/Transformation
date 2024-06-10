using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private float _speedRotation = 35.0f;
    [SerializeField] private float _speedIncrease = 0.5f;

    private float _minSize = 1.0f;
    private float _maxSize = 1.5f;
    
    private bool isGrowing = true;

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
        Vector3 currentScale = transform.localScale;

        if (isGrowing)
        {
            currentScale += Vector3.one * _speedIncrease * Time.deltaTime;

            if (currentScale.x >= _maxSize)
            {
                currentScale = Vector3.one * _maxSize;
                isGrowing = false;
            }
        }
        else
        {
            currentScale -= Vector3.one * _speedIncrease * Time.deltaTime;

            if (currentScale.x <= _minSize)
            {
                currentScale = Vector3.one * _minSize;
                isGrowing = true;
            }
        }

        transform.localScale = currentScale;
    }
}
