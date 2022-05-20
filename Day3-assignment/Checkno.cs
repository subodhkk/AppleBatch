using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                            //C# program to check whether a number is negative, positive or zero

namespace Day3_assignment
{
    internal class Checkno
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the Number");
            float a= Convert.ToSingle(Console.ReadLine());

            if (a > 0)
                Console.WriteLine(" Entered number " + a + " is Positive ");
            else if (a < 0)
                Console.WriteLine(" Entered number " + a + " is Negative ");
            else 
                Console.WriteLine(" Entered number is Zero");
            

        }
    }
}
