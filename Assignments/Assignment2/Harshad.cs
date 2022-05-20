using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Assignment2
{
    internal class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int t = a;
            int sum = 0;
            while (a > 0)
            {
                int digit = a % 10;
                sum = sum + digit;
                a = a / 10;

            }
            if (t % sum == 0)
                Console.WriteLine("Its Harshad No");
            else
                Console.WriteLine("Not harshad no");
        }
    }
    
}
