using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookRaycaster : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private float _maxDistance;
    [SerializeField] private Camera _camera;

    public RaycastHit Raycast()
    {
        RaycastHit hit;
        Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, _maxDistance, _layerMask);
        return hit;
    }
}
