using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMonitorView : MonoBehaviour
{
    public Camera MainCamera;
    public Equipment Eq;
    public GameObject Arrows;

    public void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x - 40.50f, MainCamera.transform.position.y, MainCamera.transform.position.z);
        Eq.ChangePosition(-40.50f);
        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}