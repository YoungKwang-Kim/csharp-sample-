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
            // ������ ���� Ʃ��
            var a = ("���۸�", 9999);
            Debug.Log($"{a.Item1}, {a.Item2}");

            // ���� Ʃ��
            var b = (name: "�ڻ���", age: 17);
            Debug.Log($"{b.name}, {b.age}");

            // ����
            var (name, age) = b; // (var name, var age) = b;
            Debug.Log($"{name}, {age}");

            // ����2
            var (name2, age2) = {}
        }
    }

}

