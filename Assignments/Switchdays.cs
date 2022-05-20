using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Switchdays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number corresponding to Day");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("It's a Monday");
                    break;

                case 2:
                    Console.WriteLine("It's a Tueday");
                    break;

                case 3:
                    Console.WriteLine("It's a Wenesday");
                    break;

                case 4:
                    Console.WriteLine("It's a Thursday");
                    break;

                case 5:
                    Console.WriteLine("It's a Friday");
                    break;

                case 6:
                    Console.WriteLine("It's a Satarday");
                    break;

                case 7:
                    Console.WriteLine("It's a Sunday");
                    break;

                default:
                    Console.WriteLine(" Error Day does not Exist");
                    break;
            }

        }
    }
}
