using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RefReturn
{
    public class RefReturn : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_loacal_price = carrot.GetPrice();

            carrot.PrintPrice();
            Debug.Log($"Ref Local Price : {ref_local_price}");
            Debug.Log($"Normal Local Price : {normal_loacal_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Debug.Log($"Ref Local Price : {ref_local_price}");
            Debug.Log($"Normal Local Price : {normal_loacal_price}");
        }
    }

    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Debug.Log($"Price : {price}");
        }
    }
}

