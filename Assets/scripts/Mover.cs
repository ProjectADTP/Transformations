using UnityEngine;
using UnityEngine.PlayerLoop;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speed * time.deltaTime);
    }
}

