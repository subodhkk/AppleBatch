using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number= ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 5 == 0 && n % 11 == 0)
                Console.WriteLine("!! Entered number is Divisible by 5 & 11 Both !!");
            else
                Console.WriteLine("!! Entered number is NOT Divisible by 5 & 11 !!");
        }
    }
}
