using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConostructorWithProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get 
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    public class ConstructorWithProperty : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "¼­Çö",
                Birthday = new DateTime(1991, 6, 28)
            };
            Debug.Log($"Name : {birth.Name}");
            Debug.Log($"Birthday : {birth.Birthday.ToShortDateString()}");
            Debug.Log($"Name : {birth.Age}");

        }
    }
}

