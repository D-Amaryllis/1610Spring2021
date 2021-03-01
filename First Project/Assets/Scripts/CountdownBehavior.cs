using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownBehavior : MonoBehaviour
{
    public int number;
    
    IEnumerator Start()
    {
        while (number < 4)
        {
            yield return new WaitForSeconds(0.5f);
            print("Hello");
            number++;
        }
    }
}
