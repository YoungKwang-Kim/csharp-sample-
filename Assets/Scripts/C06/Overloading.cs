using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overloading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Plus(1, 2));
        Debug.Log(Plus(1, 2, 3));
        Debug.Log(Plus(1.0, 2.4));
        Debug.Log(Plus(1, 2.4));
    }

    private void Plus()
    {
        throw new NotImplementedException();
    }

    static int Plus(int a, int b) 
    {
        Debug.Log("Calling int Plus(int, int)...");
        return a + b;
    }

    static int Plus(int a, int b, int c)
    {
        Debug.Log("Calling int Plus(int, int, int)...");
        return a + b + c;
    }

    static double Plus(double a, double b)
    {
        Debug.Log("Calling double Plus(double, double)...");
        return a + b;
    }

    static double Plus(int a, double b)
    {
        Debug.Log("Calling double Plus(int, double)...");
        return a + b;
    }

}
