using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    /* Operators are used to perform operations on variables and values
     *
     * Arithmetic Operators   Do the maths
     * +addition -subtraction *multiplication /Division %Modulus ++Increment --Decrement
     *
     * Assignment Operators  Used to assign value to operators
     * = += -_ *= /+ %= &= |= ^= >>= <<=
     *
     * Comparison Operators   used to compare two values
     * == Equal to  != Not equal   > Greater than   < Less than  >= Greater than or equal to  <= Less than or equal to
     *
     * Logical Operators    used to determine the logic between variables or values
     * &&   'Logical and'  Returns true if both statements are true
     * ||   'Logical or'   Returns true if one of the statements is true
     * !    'Logical not'  Reverse the result, returns false if the result is true
     */
    private int x = 7;
    private int y = 31;
    private string lmao = "nice";

    void Start()
    {
        Debug.Log("Time to do Math!");
    }

    void Update()
    {
        Debug.Log(y * 2 + x); 
        Debug.Log("Nice");
    }
}
