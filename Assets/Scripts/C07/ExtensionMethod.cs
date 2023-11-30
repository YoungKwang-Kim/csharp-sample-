using MyExtension;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result *= myInt;
            
            return result;
        }
    }

    static class Name
    {
        public static string MyName(this string myName)
        {
            return myName;
        }
    }
}

namespace ExtensionMethod
{
    public class ExtensionMethod : MonoBehaviour
    {
        void Start()
        {
            Debug.Log($"3^2 : {3.Square()}");
            Debug.Log($"3^4 : {3.Power(4)}");
            Debug.Log($"2^10 : {2.Power(10)}");
        }
    }
}

