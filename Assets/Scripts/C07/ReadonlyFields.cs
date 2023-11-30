using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReadonlyFields
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            min = v2;
        }

        public void Changemax(int newMax)
        {
            //max = newMax;
        }
    }
    public class ReadonlyFields : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}

