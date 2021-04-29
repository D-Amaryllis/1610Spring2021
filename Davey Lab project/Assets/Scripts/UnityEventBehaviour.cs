using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class UnityEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
   
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
