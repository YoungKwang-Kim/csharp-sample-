using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Conostructor
{
    public class Constructor : MonoBehaviour
    {
        class AnimalGenerator
        {
            public Cat MakeCat()
            {
                Cat cat = new Cat();
                return cat;
            }

            public Dog MakeDog()
            {
                Dog dog = new Dog();
                return dog;
            }
        }

    

        class Dog
        {
            public string name;

            public Dog() 
            {
                name = "";
            }
            public Dog(string _Name)
            {
                name = _Name;
            }

            public void Bow()
            {
                Debug.Log("Bow");
            }
        }
        


        class Cat
        {
            // �������
            public string Name;
            public string Color;

            // �޼���
            public Cat()
            {
                Name = "";
                Color = "";
            }

            public Cat(string _Name, string _Color)
            {
                Name = _Name;
                Color = _Color;
            }

            ~Cat()
            {
                Debug.Log($"{Name} : �߰�");
            }

            public void Meow()
            {
                Debug.Log($"{Name} : �߿�");
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            {
                Cat kitty = new Cat("ŰƼ", "�Ͼ��");
                kitty.Meow();
                Debug.Log($"{kitty.Name} : {kitty.Color}");

                Cat nero = new Cat("�׷�", "������");
                nero.Meow();
                Debug.Log($"{kitty.Name} : {kitty.Color}");
            }
            {
                AnimalGenerator ag = new AnimalGenerator();
                Cat cat2 = ag.MakeCat();
                cat2.Meow();

                AnimalGenerator ag2 = new AnimalGenerator();
                Dog dog2 = ag2.MakeDog();
                dog2.Bow();
            }
        }
    }
}

