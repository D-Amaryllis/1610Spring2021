using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;


    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }

        /* This is an example of a situation in which to use a forLoop
         We want it to add all the numbers between one and 10 together*/
        
        int total = 0; //we begin by creating a variable, the 'total'
        
        //for (do this before loop; check this before running; do at end)
        for (int count = 1; count <= 10; count++) // the ++ is just short for count = count + 1.  If I want it to add more than one I say count += x  
        {
            total = count + total;
        }    
        Debug.Log("The answer is " +total);
    }
}
