using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingActivityStatus : MonoBehaviour
{
    public ConnectionWithPlug connectionWithPlug;
    public GameObject CorrectNumber;

    public void Update()
    {
        if (connectionWithPlug.IsPlugConnected == true)
        {
            CorrectNumber.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            CorrectNumber.SetActive(false);
            gameObject.SetActive(true);
        } 
    }
}