using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Debug.Log("AbstractBase.PrivateMethodA");
        }
        public void PublicMethodA()
        {
            Debug.Log("AbstractBase.PublicMethodA()");
        }
        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Debug.Log("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
        
  
    public class AbstractClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}

