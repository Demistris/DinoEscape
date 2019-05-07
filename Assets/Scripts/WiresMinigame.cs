using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiresMinigame : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject Arrows;

    public float BackTarget;
    public BackArrow backArrow;

    public void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x - 81f, MainCamera.transform.position.y, MainCamera.transform.position.z);
        backArrow.BackTarget = BackTarget;
        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}