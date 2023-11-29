using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionalParameter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrintProfile("�߱�");
        PrintProfile("����", "010-123-1234");
        PrintProfile(name: "����");
        PrintProfile(name: "����", phone:"010-789-7890");

    }

    static void PrintProfile(string name, string phone = "")
    {
        Debug.Log($"Name:{name}, Phone:{phone}");
    }
    
}
