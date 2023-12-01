using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArraySample
{
    public class ArraySample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int score in scores)
            { Debug.Log(score); }

            int sum = 0;
            foreach (int score in scores)
            { sum += score; }

            int average = sum / scores.Length;

            Debug.Log($"Average Score : {average}");
        }
    }
}

