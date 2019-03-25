using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{

    public bool[] stuff;

    void Start()
    {
        stuff = new bool[] { true, false, false, false, false };
    }

    void Update()
    {
        
    }

    public void AddToEq(short _id)
    {
        stuff[_id] = true;
    }
}
