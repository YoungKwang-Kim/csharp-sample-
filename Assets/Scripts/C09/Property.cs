using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Property
{
    class birthdayInfo
    {
        private string name;       // ���� ���� ����
        private DateTime birthday; // ���� ���� ����

        public string Name
        {
            get { return name;}
            set { name = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year; }
        }
    }

    public class Property : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            birthdayInfo birth = new birthdayInfo();
            birth.Name = "����";
            birth.Birthday = new DateTime(1991, 6, 28);
            Debug.Log($"Name : {birth.Name}");
            Debug.Log($"Birthday : {birth.Birthday.ToShortDateString()}");
            Debug.Log($"Age : {birth.Age}");

            // birth.Name = "ȫ�浿";    // set (����)
            // string name = birth.Name; // get (�б�)
        }
    }
}

