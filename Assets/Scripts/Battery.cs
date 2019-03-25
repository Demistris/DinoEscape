using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public Equipment eq;
    private readonly short id = 1;
    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }

    public void OnClick()
    {
        eq.AddToEq(id);
        sr.enabled = false;
    }
}
