using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


                                //C# program to check whether a year is leap year or not


namespace Day3_assignment
{
    internal class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year =Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
                Console.WriteLine("The Entered year is Leap Year");
            else
                Console.WriteLine("The Entered year is not Leap Year");

        }
    }
}
