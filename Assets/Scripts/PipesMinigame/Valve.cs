using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    public Pipe[] pipes;

    private float[] correctAngles;

    private void Start()
    {
        correctAngles = new float[17] { 0f, 270f, 90f, 0f, 90f, 270f, 0f, 90f, 180f, 0f, 180f, 0f, 270f, 90f, 90f, 0f, 180f};
    }

    private void OnMouseDown()
    {
        short i = 0;

        foreach (Pipe p in pipes)
        {
            if (p.transform.eulerAngles.z == correctAngles[i++]) continue;
            else break;
        }

        if (i >= 17) Debug.Log("Pipe minigame completed succesfuly");
        else Debug.Log("Pipe minigame wrong combination");
    }
}
