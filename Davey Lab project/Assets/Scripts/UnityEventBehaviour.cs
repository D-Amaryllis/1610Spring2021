using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class UnityEventBehaviour : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myTrigger.Invoke();
        }
    }
}
