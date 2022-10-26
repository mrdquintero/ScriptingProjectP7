using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create an integer variable
    int myInt = 5;    
    
    
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    //Creating a function that will multiply a value by another value
    int MultiplyByTwo(int number)
    {
        //Create a variable to hold my results
        int result;        
        //multiplying the passed variable by a value
        result = number * 2;
        return result;
    }   // Update is called once per frame
    void Update() 
    {
    }
}
