using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface4
{
    interface Isay
    {
        void Say();
    }
    class A : Isay
    {
        public void MakeB()
        {
            B b = new B();
            b.Talk(this);           // A가 B에게 Talk를 시킴!!
        }

        public void Say()
        {
            Debug.Log("Say");
        }
    }

    class B
    {
        public void Talk(Isay say)
        {
            Debug.Log("Talk");
            say.Say();
        }
    }

    class C : Isay
    {
        public void MakeB()
        {
            B b = new B();
            b.Talk(this);           // C가 B에게 Talk를 시킴!!
        }

        public void Say()
        {
            Debug.Log("Say~~~ Ho~ Ho~~");
        }
    }

    public class Interface4 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            A a = new A();
            a.MakeB();
            C c = new C();
            c.MakeB();
        }
    }
}


