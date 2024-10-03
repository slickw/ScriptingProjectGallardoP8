using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type integer
    int myInt = 12;


    // Start is called before the first frame update
    void Start()
    {
        // I am going to run myInt thru my fucntion to multiply by two
        myInt = MultiplyByTwo(myInt);
        //i'm going to print the results to the console
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }


    //Creating a function that takes an int parameter and multiplies by 2

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;

    

    }
}
    
    