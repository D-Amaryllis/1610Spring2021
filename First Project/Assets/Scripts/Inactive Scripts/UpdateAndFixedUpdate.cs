using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    //Called every physcis step
    //FixedUpdate intervals are consistent
    //used for regular updates such as:
    // Adjusting physics (Ridgidbody) objects
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
