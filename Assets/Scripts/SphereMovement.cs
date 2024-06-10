using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
