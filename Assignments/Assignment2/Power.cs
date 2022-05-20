using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Assignment2
{
    internal class Power
    {
        static void Main(string[] args)
        {
            int b, e, result = 1;
            Console.WriteLine("Base Number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Exponent Number : ");
            e = Convert.ToInt32(Console.ReadLine());


            while (e!= 0)
            {
                result = result * b;
                --e;
            }

            Console.WriteLine("Result = "+result);

        }
    }
}
