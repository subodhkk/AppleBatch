using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Assignment2
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a=Convert.ToInt32(Console.ReadLine());
            int n = a;
            int rev = 0;

            while (a > 0)
            {
                int d = a % 10;
                rev = rev * 10 + d;
                a = a / 10;
            }
            if (rev == n)
                Console.WriteLine("Number is PALINDROME");
            else
                Console.WriteLine("NOT a PALINDROME");
        }
    }


    internal class Palindrome500
    {
        static void Main(string[] args)
        {
            int n = 0;
            int rev = 0;
            for (int i = 100; i <= 500; i++)
            {
                n = i;
                for (int j = 1; j <= n; j++)
                {
                    rev = rev + (n % 10);
                    n = n / 10;
                    j = 0;
                }
            }
        }
    }
}
