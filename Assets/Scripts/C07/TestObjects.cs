using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjects : MonoBehaviour
{
    class Person
    {
        string name;
        int age;

        Gun gun;

        public void SetGun(Gun gun)
        {
            Debug.Log("SetGun");
        }

        public void Shoot()
        {
            Debug.Log("Shoot!!");
        }

        public Person()
        {
            name = "";
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }
    }

    class Gun
    {
        string name;

        public Gun(string name)
        {
            this.name = name;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        // »ç¶÷ ÇÒ´ç
        Person a = new Person("È«±æµ¿", 23);

        // ÃÑ ÇÒ´ç
        Gun gun = new Gun("K1");
        a.SetGun(gun);
        a.Shoot();
    }
}
