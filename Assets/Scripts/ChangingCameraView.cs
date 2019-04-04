using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingCameraView : MonoBehaviour
{
    public GameObject RightArrow;
    public GameObject LeftArrow;
    public Equipment eq;

    public void OnRightArrowClicked()
    {
        transform.position = new Vector3(gameObject.transform.position.x + 20.25f, transform.position.y, transform.position.z);
        eq.ChangePosition(20.25f); // change position of equipment
        UpdateArrowsVisibility();
    }

    public void OnLeftArrowClicked()
    {
        transform.position = new Vector3(gameObject.transform.position.x - 20.25f, transform.position.y, transform.position.z);
        eq.ChangePosition(-20.25f); // change position of equipment
        UpdateArrowsVisibility();
    }

    private void UpdateRightArrowVisibility()
    {
        bool isMaxToTheRight = Mathf.Approximately(gameObject.transform.position.x, 20.25f);
        RightArrow.SetActive(!isMaxToTheRight);
    }

    private void UpdateLeftArrowVisibility()
    {
        bool isMaxToTheLeft = Mathf.Approximately(gameObject.transform.position.x, -20.25f);
        LeftArrow.SetActive(!isMaxToTheLeft);
    }

    private void UpdateArrowsVisibility()
    {
        UpdateRightArrowVisibility();
        UpdateLeftArrowVisibility();
    }
}