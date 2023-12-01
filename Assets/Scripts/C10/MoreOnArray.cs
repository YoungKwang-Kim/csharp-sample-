using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreOnArray
{


    public class MoreOnArray : MonoBehaviour
    {
        public static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        public static void Print(int value)
        {
            Debug.Log(value);
        }

        // Start is called before the first frame update
        void Start()
        {

            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
            {
                Debug.Log($"{score}");
            }

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));

            Debug.Log($"Number of diamensions : { scores.Rank}");

            Debug.Log($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");

            Debug.Log($"Linear Search : 90 is at " + $"{Array.IndexOf<int>(scores, 90)}");

            Debug.Log($"Everyone passed ? :" + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            Debug.Log($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            Debug.Log($"Old length of scores : " + $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            Debug.Log($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
        }
    }
}