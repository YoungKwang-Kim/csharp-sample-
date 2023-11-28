using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class IntegralTypes : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning";
        Debug.Log(greeting);

        // IndexOf()
        Debug.Log($"IndexOF: 'good' : {greeting.IndexOf("Good")}");
        Debug.Log($"IndexOF: 'o' : {greeting.IndexOf("o")}");

        // LastIndexOf()
        Debug.Log($"LastIndexOf 'Good' : {greeting.LastIndexOf("Good")}");
        Debug.Log($"LastIndexOf 'g' : {greeting.LastIndexOf("g")}");

        // StartWidth
        Debug.Log($"");
        Debug.Log($"");

        // EndWidth()
        Debug.Log($"");
        Debug.Log($"");

        // Contains()
        Debug.Log($"");
        Debug.Log($"");

        // Replace()
    }
}
