using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    CharacterController cc;

    void Awake() 
    {
        Debug.Log("Awake");
    }

    void Enable()
    {
        Debug.Log("Enable");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
}
