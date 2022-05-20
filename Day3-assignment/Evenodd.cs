using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                            //C# program to check whether a number is even or odd

namespace Day3_assignment
{
    internal class Evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine(" Entered number is Even ");
            else
                Console.WriteLine(" Entered number is Odd");

        }
    }
}
