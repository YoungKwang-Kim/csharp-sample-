using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

namespace E0602
{
    public class Return : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log($"5��° �Ǻ���ġ �� : {Fibonacci(5)}");
            PrintProfile("", "123-4567");
            PrintProfile("�ڻ���", "456=1230");
        }

        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Debug.Log("�̸��� �Է����ּ���.");
                return;
            }
            Debug.Log($"Name: {name}, Phone: {phone}");
        }
    }
}


