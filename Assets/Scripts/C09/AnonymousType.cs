using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnonymousType
{
    public class AnonymousType : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var a = new { Name = "�ڻ���", Age = 123 };
            Debug.Log($"Name:{a.Name}, Age:{a.Age}");

            var b = new { Subject = "����", Scores = new int[] { 90, 80, 70, 60 } };

            Debug.Log($"Subject:{b.Subject}, Scores: ");
            foreach (var score in b.Scores)
                Debug.Log($"score");
        }
    }
}

