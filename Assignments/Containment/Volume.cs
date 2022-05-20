using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Containment
{
    internal class Volume1

    {
        public void Volume()
        {

        }
        public double Volume(double r)
        {
            double a1 = (4 / 3) * (22 / 7) * r * r * r;
            return a1;
        }
        public double Volume(double r,double h)
        {
            double a2 = (22 / 7) * r * r * h;
            return a2;
        }
        public double Volume(double l, double b,double h)
        {
            double a3 = l * b * h;
            return a3;

        }

    }

    class VolumeRun
    {
        static void Main(string[] args)
        {
            Volume1 v1 = new Volume1();
            //v1.Volume(20);
            //v1.Volume(5,10);
            //v1.Volume(5, 6, 8);


            Console.WriteLine("Volume of Sphere is "+  v1.Volume(5));
            Console.WriteLine("Volume of Cyclinder is " + v1.Volume(5,10));
            Console.WriteLine("Volume of Cuboid is " + v1.Volume(5,6,8));

        }
    }
}
