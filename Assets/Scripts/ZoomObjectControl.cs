using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomObjectControl : MonoBehaviour
{
    //Checking if there is a zoom on the object

    public static bool zoomActive = false;

    void OnMouseDown()
    {
        if(IsZoomActive())
        {
            zoomActive = false;
        }
        else
        {
            zoomActive = true;
        }
    }

    private bool IsZoomActive()
    {
        return zoomActive == true;
    }
}