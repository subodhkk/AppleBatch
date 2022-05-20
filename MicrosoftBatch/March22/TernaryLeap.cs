using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                // Check leap year or not using ternary operator

namespace MicrosoftBatch.March21
{
    internal class TernaryLeap
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            string a;
            a = year % 4 == 0 ? "Leap year" : "Non Leap year";
            Console.WriteLine(a);
        }
    }
}
