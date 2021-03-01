using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class coroutineEventBehavior : MonoBehaviour
{
    public int number, maxNumber;
    public float holdTime = 1f;
    private WaitForSeconds wfsObj;
    public UnityEvent startEvent;
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(holdTime);

        while (number < maxNumber)
        {
            startEvent.Invoke();
            yield return wfsObj;
        }
    }
}
