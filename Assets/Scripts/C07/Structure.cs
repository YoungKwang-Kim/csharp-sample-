using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Structure
{
    public class Structure : MonoBehaviour
    {
        struct Point3D
        {
            public int X;
            public int Y;
            public int Z;

            public Point3D(int X, int Y, int Z)
            {
                this.X = X; 
                this.Y = Y; 
                this.Z = Z;
            }

            public override string ToString()
            {
                return string.Format($"{X} {Y} {Z}");
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            Point3D p3d1;
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Debug.Log(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;
            p3d3.Z = 400;

            Debug.Log(p3d2.ToString());
            Debug.Log(p3d3.ToString());
        }
    }
}

