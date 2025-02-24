using UnityEngine;
using UnityEngine.PlayerLoop;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var nextPosition = transform.position;
        nextPosition.z += _speed;
        transform.position = nextPosition;
    }
}

