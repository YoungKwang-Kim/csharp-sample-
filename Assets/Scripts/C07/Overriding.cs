using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Debug.Log("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Debug.Log("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Debug.Log("Double-Barrel Cannons Armed");
            Debug.Log("Micro-Rocket Launcher Armed");
        }
    }


    public class Overriding : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Creating ArmorSuite");
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialize();

            Debug.Log("\nCreating IronMan...");
            ArmorSuite ironman = new ArmorSuite();
            ironman.Initialize();

            Debug.Log("\nCreating WarManchine...");
            ArmorSuite warmachine = new ArmorSuite();
            warmachine.Initialize();
        }
    }
}

