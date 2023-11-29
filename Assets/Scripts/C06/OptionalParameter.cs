using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionalParameter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrintProfile("중근");
        PrintProfile("관순", "010-123-1234");
        PrintProfile(name: "봉길");
        PrintProfile(name: "동주", phone:"010-789-7890");

    }

    static void PrintProfile(string name, string phone = "")
    {
        Debug.Log($"Name:{name}, Phone:{phone}");
    }
    
}
