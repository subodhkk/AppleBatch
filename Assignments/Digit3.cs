using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Digit3
    {
        static void Main(string[] args)
        {
            int first, last, sum;
            Console.WriteLine(" Enter the 3 digit number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 99 && num < 1000)
            {
                last = num % 10;
                // middle = (num / 10)%10;
                first = (num / 100);

                sum = last + first;
                Console.WriteLine(" Entered number is a 3 digit and sum of fist and last digit is= " + sum);

            }

            else
                Console.WriteLine("Entered number is not 3 digit");

        }
    }
}
