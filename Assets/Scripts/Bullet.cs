using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _bulletLife = 3;
    public GameObject _enemy;

    private void Awake()
    {
        Destroy(gameObject, _bulletLife);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(_enemy);
    }
}
