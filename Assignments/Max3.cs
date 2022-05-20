using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Max3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 Numbers= ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("Maximum is= " + a);
            else if (b > a && b > c)
                Console.WriteLine("Maximum is= " + b);
            else if (c > b && c > a)
                Console.WriteLine("Maximum is= " + c);
            else
                Console.WriteLine("All are Equal");

        }
    }
}
