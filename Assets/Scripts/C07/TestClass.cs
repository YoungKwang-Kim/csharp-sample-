using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


namespace TestClass
{
    public class TestClass : MonoBehaviour
    {
        class Cat
        {
            string name;
            int age;
            
            public Cat(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        class CatTown
        {
            public Cat MakeCat(string name, int age)
            {
                Cat cat = new Cat(name, age);
                return cat;
            }
        }

        class Weapon
        {
            protected string name;

            public Weapon(string name)
            {
                this.name = name;
            }

            public void WeaponAttack()
            {
                if (this.name != null)
                {
                    Debug.Log("무기 공격");
                }
            }


        }

        class Sword : Weapon
        {
            // Weapon 클래스에 name이 있어서 없어도 됌
            // private string name;

            public Sword(string name) : base(name) { }
            //{
            //    this.name = name; // base(name) { }로 대체됨
            //}    

            public void Stab()
            {
                Debug.Log("찌르기!");
            }
        }

        class Gun : Weapon
        {
            // Weapon 클래스에 name이 있어서 없어도 됌
            // private string name;

            public Gun(string name) : base(name) { }
            //{
            //    this.name = name; // base(name) { }로 대체됨
            //}
            public void Shoot()
            {
                Debug.Log("총 발사");
            }
        }

        class Person
        {
            string name;
            int age;
            float height;
            // Gun gun;
            // Sword sword;
            Weapon weapon;

            public Person()
            {
                this.name = "";
                this.age = 0;
                this.height = 0;
            }

            public Person(string name) : this(name, 0) { }

            public Person(string name, int age) : this(name, age, 0) { }

            public Person(string name, int age, float height)
            {
                this.name = name;
                this.age = age;
                this.height = height;
            }

            public void SetWeapon(Weapon weapon)
            {
                Debug.Log("무기 장착");
                
            }
            public void Attack(Weapon weapon)
            {
                if (this.weapon != null)
                {
                    this.weapon.WeaponAttack();
                }
            }



            public void GetName()
            {
                Debug.Log(this.name);
            }

            public void GetAge()
            {
                Debug.Log(this.age);
            }

            public Person DeepCopy()
            {
                Person person = new Person();
                person.name = this.name;
                person.age = this.age;

                return person;
            }
        }

        class Mother
        {
            public Person MakePerson(string name, int age)
            {
                Person person = new Person(name, age);
                return person;
            }
        }


        // Start is called before the first frame update
        void Start()
        {
            CatTown catTown = new CatTown();
            Cat cat1 = catTown.MakeCat("Nero", 6);

            Mother mother = new Mother();
            Person person1 = mother.MakePerson("영수", 20);
            Person person2 = new Person("영희", 21);

            person1.GetName();
            person1.GetAge();
            person2.GetName();
            person2.GetAge();

            Weapon weapon = new Weapon("권총");
            person1.SetWeapon(weapon);
            person1.Attack(weapon);
        }
    }
}

