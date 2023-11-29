using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SwapByValue
{
    public class SwapByValue : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int x = 3; 
            int y = 4;

            Debug.Log($"x:{x}, y:{y}");

            Swap(x, y);

            Debug.Log($"x:{x}, y:{y}");
        }

        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a; 
            a = temp;
        }



    }
}


