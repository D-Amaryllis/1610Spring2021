using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float downBoundary = -5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < downBoundary)
        {
            Destroy(gameObject);
        }
    }
}
