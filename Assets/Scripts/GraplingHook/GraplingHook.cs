using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraplingHook : MonoBehaviour
{
    [SerializeField] private HookRaycaster _hookRaycaster;
    [SerializeField] private HookRenderer _hookRenderer;
    [SerializeField] private Player _player;
    [SerializeField] private float _jointDamper = 10;
    [SerializeField] private float _jointSpring = 5;

    private SpringJoint _springJoint;
    public AudioClip Shoot;
    public void CreateHook()
    {
        RaycastHit hit = _hookRaycaster.Raycast();

        if (hit.collider != null)
        {
            Vector3 grapplePoint = hit.point;
            _hookRenderer.DrawRope(grapplePoint);

            _springJoint = _player.gameObject.AddComponent<SpringJoint>();
            _springJoint.autoConfigureConnectedAnchor = false;
            _springJoint.connectedAnchor = grapplePoint;

            float grappleDistance = Vector3.Distance(transform.position, grapplePoint);

            _springJoint.maxDistance = grappleDistance;
            _springJoint.minDistance = grappleDistance;

            _springJoint.damper = _jointDamper;
            _springJoint.spring = _jointSpring;
        }
    }

    public void DisableHook()
    {
        Destroy(_springJoint);
        _hookRenderer.Disable();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().PlayOneShot(Shoot);
        }
    }
}
