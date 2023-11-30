using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ReadonlyStruct
{
    readonly struct RGBColor
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;
        public RGBColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    public class ReadonlyStruct : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            RGBColor Red = new RGBColor(255, 0, 0);
            // Red.G = 100; // 읽기 전용이라 에러
        }
    }
}

