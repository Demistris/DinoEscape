using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomableObject : MonoBehaviour
{
    [SerializeField] private float _size = 1;

    private void OnMouseDown()
    {
        GameMaster.Instance.ZoomCamera.ZoomToObject(this, _size);
    }
}
