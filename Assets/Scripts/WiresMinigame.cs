using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiresMinigame : MonoBehaviour
{
    public Camera MainCamera;
    public Equipment Eq;
    public GameObject Arrows;

    public void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y + 20.25f, MainCamera.transform.position.z);
        //Eq.ChangePosition(-40.50f);
        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}