using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomObject : MonoBehaviour
{
    void Start()
    {
        GetComponent<Camera>().enabled = false;
    }

    //Checking if camera should be zoomed and to which object

    void Update()
    {
        if(ZoomObjectControl.zoomActive == true)
        {
            GetComponent<Camera>().enabled = true;
        }
        else
        {
            GetComponent<Camera>().enabled = false;
        }
    }

    void FindObjectToZoom()
    {

    }
}
