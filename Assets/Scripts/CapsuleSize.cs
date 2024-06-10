using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSize : MonoBehaviour
{
    [SerializeField] private float _speed = 0.1f;

    private float _minSize = 1.0f;
    private float _maxSize = 2.0f;

    private bool isGrowing = true;

    private void Update()
    {
        increase();
    }

    private void increase()
    {
        Vector3 currentScale = transform.localScale;

        if (isGrowing)
        {
            currentScale += Vector3.one * _speed * Time.deltaTime;

            if (currentScale.x >= _maxSize)
            {
                currentScale = Vector3.one * _maxSize;
                isGrowing = false;
            }
        }
        else
        {
            currentScale -= Vector3.one * _speed * Time.deltaTime;

            if (currentScale.x <= _minSize)
            {
                currentScale = Vector3.one * _minSize;
                isGrowing = true;
            }
        }

        transform.localScale = currentScale;
    }
}
