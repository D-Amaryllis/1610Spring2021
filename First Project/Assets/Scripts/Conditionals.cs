using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    
    public int a, b, c;
    // Start is called before the first frame update
    void Start()
    {
        if (a + b == c)
        {
           print(true); 
        }
        else
        {
            print(false);
        }
    }
    
}
