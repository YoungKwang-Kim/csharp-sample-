using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConditionalOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null;
        a?.Add("具备");
        a?.Add("绵备");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"Count : {a?[0]}");
        Debug.Log($"Count : {a?[1]}");

        a = new ArrayList();

        a?.Add("具备");
        a?.Add("绵备");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"Count : {a?[0]}");
        Debug.Log($"Count : {a?[1]}");

        Person person = new Person();
        person.Walk();
    }
}

public class Person
{
    // 函荐
    int age;

    // 窃荐
    public void Walk()
    {

    }
}
