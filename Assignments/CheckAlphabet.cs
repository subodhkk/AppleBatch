using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CheckAlphabet
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter any character: ");
            char ch = Convert.ToChar(Console.Read());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " is a Digit. ");
            }
            else
            {
                Console.WriteLine(ch + " is a Special character");
            }

        }
    }
}
