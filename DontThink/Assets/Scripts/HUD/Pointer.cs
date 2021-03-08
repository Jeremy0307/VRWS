using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{

    [SerializeField] private float _defaultLength = 5.0f;

    [SerializeField] private GameObject _dot = null;

    [SerializeField] private VRInputModule _inputModule = null;

    private LineRenderer _lineRenderer = null;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }


    private void Update()
    {
        UpdateLine();
    }


    void UpdateLine()
    {
        float targetLength = _defaultLength;

        RaycastHit hit = CreateRaycast(targetLength);

        Vector3 endPosition = transform.position = (transform.forward * targetLength);

        if (hit.collider != null)
            endPosition = hit.point;

        _dot.transform.position = endPosition;

        _lineRenderer.SetPosition(0, transform.position);
        _lineRenderer.SetPosition(1, endPosition);
    }

    private RaycastHit CreateRaycast (float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, _defaultLength);

        return hit;
    }
}
