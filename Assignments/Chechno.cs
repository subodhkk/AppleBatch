using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Chechno
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the Number");
            float a = Convert.ToSingle(Console.ReadLine());

            if (a > 0)
                Console.WriteLine(" Entered number " + a + " is Positive ");
            else if (a < 0)
                Console.WriteLine(" Entered number " + a + " is Negative ");
            else
                Console.WriteLine(" Entered number is Zero");


        }
    }
}
