using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CoffeeSample
{
    public class CoffeeSample : MonoBehaviour
    {
        class Espresso
        {
            public string name;

            public void Drink()
            {
                Debug.Log("Drink!!!");
            }
        }
        class Americano : Espresso
        {
            public int water;

            //public void Drink()
            //{
            //    Debug.Log("��! ���ִ�");
            //}

        }

        class Latte : Espresso
        { 
            public int milk;

            //public void Drink()
            //{
            //    Debug.Log("��! ���ϴ�");
            //}
        }

        class Person
        {
            public Espresso coffee;

            public void Drink()
            {
                if ( coffee != null )
                {
                    coffee.Drink();
                }
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            Espresso espresso = new Espresso();
            espresso.name = "�ɳ�AA";
            espresso.Drink();
            
            Americano americano = new Americano();
            americano.name = "�ɳ�BB";
            americano.water = 280;
            americano.Drink();

            Latte latte = new Latte();
            latte.name = "�ɳ�CC";
            latte.milk = 200;
            latte.Drink();
        }

    }
}

