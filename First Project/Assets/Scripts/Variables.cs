using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variables : MonoBehaviour
{
    /* variables are storage for data in the memory of the script.
     Like labelled storage tubs.
     
    int num = 100;           Integers (whole numbers), without decimals.
    float rate = 10.2f;      Stores floating numbers with decimals, such as 19.99.
    double yeah = 10.2f;     Don't use this.  It is the same as float, but its more accurate and takes longer to calculate.  Float is faster.
    char code = 'C';         just one character 'c' 'b'
    bool isValid = true;     bool can only be true or false
    string name = "Steve";   just some letters, my dude.  "Hello world!"*/

    private int cents = 60;

    void Start ()
    {
        Debug.Log("I need 69 cents, and I have " + cents + "cents");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("I have " + cents + "cents");

            if (cents < 69)
            {
                cents++;
                Debug.Log("I add a penny");
            }
            if (cents == 69)
            {
                Debug.Log("6Nice9");
            }
        }
    }
}