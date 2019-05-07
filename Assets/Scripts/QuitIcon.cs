using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitIcon : MonoBehaviour
{
    public Camera MainCamera;
    public Equipment Eq;
    public GameObject Arrows;
    public GameObject inputField;

    private void OnMouseDown()
    {
        inputField.gameObject.SetActive(false); // disable input field if it was displayed
        MainCamera.transform.position = new Vector3(40.50f, MainCamera.transform.position.y, MainCamera.transform.position.z);
        Eq.ChangePosition(81f); // change position of equipment
    }
}
