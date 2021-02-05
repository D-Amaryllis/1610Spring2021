using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Rigidbody.AddForce(-transform.forward * 500f);
        Rigidbody.useGravity = true;
    }
}
