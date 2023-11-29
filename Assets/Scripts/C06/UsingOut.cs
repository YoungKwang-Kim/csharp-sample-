using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 20;
        int b = 3;
        // int c;
        // int d;

        Divide(a, b, out int c, out int d);

        Debug.Log($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
    }


    static void Divide(int a, int b, out int quotient, out int remainder)
    {
        quotient = a / b;
        remainder = a % b;
    }
}
