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
            //    Debug.Log("아! 맛있다");
            //}

        }

        class Latte : Espresso
        { 
            public int milk;

            //public void Drink()
            //{
            //    Debug.Log("아! 진하다");
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
            espresso.name = "케냐AA";
            espresso.Drink();
            
            Americano americano = new Americano();
            americano.name = "케냐BB";
            americano.water = 280;
            americano.Drink();

            Latte latte = new Latte();
            latte.name = "케냐CC";
            latte.milk = 200;
            latte.Drink();
        }

    }
}

