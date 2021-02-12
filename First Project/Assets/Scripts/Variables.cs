using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variables : MonoBehaviour
{
    /* variables are storage for data in the memory of the script.
     Like labelled storage tubs.
     
    int num = 100;           a whole number
    float rate = 10.2f;      a number with a decimal???
    char code = 'C';         just one character
    bool isValid = true;     bool can only be true or false
    string name = "Steve";   just some letters, my dude.*/

    private int cents = 60;

    void Start ();
    {
        Debug.Log("I need 69 cents, and I have:" + cents);
    }

    void Update();
    {
        if (Input.GetKey(KeyCode.Space)) ;
        {
            Debug.Log("I have:" + cents);

            if (cents < 69) ;
            {
                cents++;
                Debug.Log("I add a penny");
            }
            if (cents = 69)
            {
                Debug.Log("Nice");
            }
        }
    }
}