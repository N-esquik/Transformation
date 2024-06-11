using UnityEngine;

public class Size : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private void Update()
    {
        Increase();
    }

    private void Increase()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
