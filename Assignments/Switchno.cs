using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Switchno
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number between 1-5 ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("1 = ONE");
                    break;
                case 2:
                    Console.WriteLine("2 = TWO");
                    break;
                case 3:
                    Console.WriteLine("3 = THREE");
                    break;
                case 4:
                    Console.WriteLine("4 = FOUR");
                    break;
                case 5:
                    Console.WriteLine("5 = FIVE");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;

            }
        }
    }
}
