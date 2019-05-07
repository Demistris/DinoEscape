using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMonitorView : MonoBehaviour
{
    public Camera MainCamera;
    public Equipment Eq;
    public GameObject Arrows;
    public bool id;

    public void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(-60.75f, 0f, -10f);
        if (id)
        {
            Eq.ChangePosition(-40.750f);
        }
        else Eq.ChangePosition(-60.75f);
        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}