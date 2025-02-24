using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multi : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, _speed * 3, 0);

        transform.Translate(Vector3.forward * _speed / 2);

        transform.localScale += Vector3.one * _speed / 10;

    }

}
