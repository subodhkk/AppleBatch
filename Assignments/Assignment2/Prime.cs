using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Assignment2
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            int flag=0;
            Console.WriteLine("Enter the Number to check Prime: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag++;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }
    }
}
