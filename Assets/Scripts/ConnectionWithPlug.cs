using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionWithPlug : MonoBehaviour
{
    private Coroutine coroutine;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("plug"))
        {
            other.gameObject.GetComponent<MoveObject>().IsMovingEnabled = false;
            other.gameObject.transform.position = transform.position;
            coroutine = StartCoroutine(COR_ForcePositions(transform, other.gameObject.transform));
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
