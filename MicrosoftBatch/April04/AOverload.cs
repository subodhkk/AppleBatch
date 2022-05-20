using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April04
{
    internal class AOverload
    {
        
        public void Area(int side)
        {
            int a=side * side;
            Console.WriteLine("Area of Square is= " +a);
        }

        public void Area( int l, int b)
        {
            int c=  l * b;
            Console.WriteLine("Area of Rectangle is= " +c);
        }

        public void Area(float c)
        {
            float d= c * c * 3.14f;
            Console.WriteLine("Area of Circle is= " +d);
        }

    }
    class Display
    {
        static void Main(string[] args)
        {
            AOverload m=new AOverload();
            m.Area(4);
            m.Area(8, 6);
            m.Area(6.2f);
            

        }
    }
        


}
