using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GraplingHook _graplingHook;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _graplingHook.CreateHook();
        else if (Input.GetMouseButtonUp(0))
            _graplingHook.DisableHook();
    }
}
