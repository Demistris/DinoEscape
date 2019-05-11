using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionWithPlug : MonoBehaviour
{
    public bool IsPlugConnected = false;
    public GameObject[] changingActivityStatus;

    private GameObject whatIsConnectedTo;
    private Coroutine coroutine;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("plug"))
        {
            if(IsPlugConnected == true)
            {
                return;
            }
            else
            {
                IsPlugConnected = true;
                other.gameObject.GetComponent<MoveObject>().IsMovingEnabled = false;
                other.gameObject.transform.position = transform.position;
                coroutine = StartCoroutine(COR_ForcePositions(transform, other.gameObject.transform));
                whatIsConnectedTo = other.gameObject;
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if(whatIsConnectedTo == other.gameObject)
        {
            IsPlugConnected = false;
            //changingActivityStatus.Update();
        }
    }

    private IEnumerator COR_ForcePositions(Transform target, Transform objectToMove)
    {
        while(objectToMove.GetComponent<MoveObject>().IsMovingEnabled == false)
        {
            objectToMove.position = target.position;
            yield return null;
        }
    }
}