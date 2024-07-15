using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 3;
    [SerializeField] private float _limitX;
    [SerializeField] private Player _player;
    
    private float _rotationX;
    private float _rotationY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    private void Update()
    {
        _rotationY = _player.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _sensitivity;
        _rotationX += Input.GetAxis("Mouse Y") * _sensitivity;
        _rotationX = Mathf.Clamp(_rotationX, -_limitX, _limitX);
        transform.localEulerAngles = new Vector3(-_rotationX, 0, 0);
        _player.transform.localEulerAngles = new Vector3(0, _rotationY, 0);
    }
}
