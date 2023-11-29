using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BasicClass
{
    public class BasicClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Cat kitty = new Cat();
            kitty.Color = "�Ͼ��";
            kitty.Name = "ŰƼ";
            kitty.Meow();
            Debug.Log($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "������";
            nero.Name = "�׷�";
            nero.Meow();
            Debug.Log($"{nero.Name} : {nero.Color}");
        }
    }

    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Debug.Log($"{Name} :�߿�");
        }
    }
}

