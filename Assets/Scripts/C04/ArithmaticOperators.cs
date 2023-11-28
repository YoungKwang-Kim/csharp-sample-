using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmaticOperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {
        {
            int a = 111 + 222;
            Debug.Log($"a : {a}");

            int b = a - 100;
            Debug.Log($"b : {b}");

            int c = b * 10;
            Debug.Log($"c : {c}");

            double d = c / 6.3;
            Debug.Log($"d : {d}");

            Debug.Log($"22 / 7 = {22 / 7}({22 % 7})");
        }
        {
            int a = 10;
            Debug.Log(a++);
            Debug.Log(++a);

            Debug.Log(a--);
            Debug.Log(--a);
        }
        {
            string result = "123" + "456";
            Debug.Log(result);

            result = "Hello" + " " + "World";
            Debug.Log(result);
        }
        {
            string result = (10 % 2) == 0 ? "Â¦¼ö" : "È¦¼ö";
            Debug.Log(result);
        }
    }
}
