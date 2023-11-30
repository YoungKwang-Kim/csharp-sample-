using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using UnityEngine;

namespace Tuple
{
    public class Tuple : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // 명명되지 않은 튜플
            var a = ("슈퍼맨", 9999);
            Debug.Log($"{a.Item1}, {a.Item2}");

            // 명명된 튜플
            var b = (name: "박상현", age: 17);
            Debug.Log($"{b.name}, {b.age}");

            // 분해
            var (name, age) = b; // (var name, var age) = b;
            Debug.Log($"{name}, {age}");

            // 분해2
            var (name2, age2) = {}
        }
    }

}

