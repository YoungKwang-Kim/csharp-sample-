using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return string.Format("{0:d5}, serial++"); }
        }
        abstract public DateTime ProductDate
        {
            get; 
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }
    public class PropertiesInAbstractClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Product product_1 = new MyProduct()
            { ProductDate = new DateTime(2023, 1, 10) };

            Debug.Log($"Product:{product_1.SerialID}, Product Date :{product_1.ProductDate}");

            Product product_2 = new MyProduct()
            {ProductDate = new DateTime(2023, 2, 3)};

            Debug.Log($"Product:{product_2.SerialID}, Product Date :{product_2.ProductDate}");
        }
    }
}

