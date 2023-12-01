using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Record
{
    record RTransaction
    {
        public string From {get; set;}
        public string To {get; set;}
        public int Amount {get; set;}

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }
        public class Record : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            RTransaction tr1 = new RTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };

            RTransaction tr2 = new RTransaction
            {
                From = "Alice",
                To = "Charlie",
                Amount = 100
            };

            Debug.Log(tr1);
            Debug.Log(tr2);
        }
    }
}

