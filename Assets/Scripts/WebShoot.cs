using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebShoot : MonoBehaviour
{
    public GameObject _bullet;
    public Camera _mainCamera;
    public Transform _spawnBullet;

    public float _shootForce;
    public float _spread;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Ray ray = _mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        Vector3 targetPoint;
        if(Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75);

        Vector3 dirWithoutSpread = targetPoint - _spawnBullet.position;

        float x = Random.Range(-_spread, _spread);
        float y = Random.Range(-_spread, _spread);

        Vector3 dirWithSpread = dirWithoutSpread + new Vector3(x, y, 0);

        GameObject currentBullet = Instantiate(_bullet, _spawnBullet.position, Quaternion.identity);

        currentBullet.transform.forward = dirWithSpread.normalized;

        currentBullet.GetComponent<Rigidbody>().AddForce(dirWithSpread.normalized * _shootForce, ForceMode.Impulse);
    }
}
