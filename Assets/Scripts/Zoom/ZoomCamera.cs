using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    [SerializeField] private Camera _targetCamera;

    private bool _isZoomed;

    public void ZoomToObject(ZoomableObject zoomableObject, float size)
    {
        if (_isZoomed)
        {
            _isZoomed = false;
            _targetCamera.enabled = false;
        }
        else
        {
            _isZoomed = true;
            transform.position = new Vector3(zoomableObject.transform.position.x, zoomableObject.transform.position.y, transform.position.z);
            _targetCamera.orthographicSize = size;
            _targetCamera.enabled = true;
        }
    }
}
