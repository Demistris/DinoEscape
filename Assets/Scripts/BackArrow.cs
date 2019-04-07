using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackArrow : MonoBehaviour
{
    public Camera MainCamera;
    public Equipment Eq;
    public GameObject LeftArrow;

    private void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x - 20.25f, MainCamera.transform.position.y, MainCamera.transform.position.z);
        Eq.ChangePosition(-20.25f); // change position of equipment
        UpdateLeftArrowVisibility();
    }

    private void UpdateLeftArrowVisibility()
    {
        LeftArrow.SetActive(true);
    }
}
