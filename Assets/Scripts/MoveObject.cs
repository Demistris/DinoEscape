﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public bool IsMovingEnabled { get; set; }
    float distance = 2.757f;

    public GameObject hookPosition;

    private void Start()
    {
        gameObject.transform.position = new Vector3(0, hookPosition.transform.position.y - 100f, 0);
    }

    private void Awake()
    {
        IsMovingEnabled = true;
    }

    private void OnMouseDown()
    {
        IsMovingEnabled = true;
    }

    private void OnMouseDrag()
    {
        if(!IsMovingEnabled)
        {
            return;
        }

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }
}
