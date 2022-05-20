using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                        // Toggle the given alphabet

namespace MicrosoftBatch.March21
{
    internal class ToggleAlpha
    {
        static void Main(string[] args)
        {
            //int a;

            Console.WriteLine("Enter alphabet");
            char a = Convert.ToChar(Console.Read());
            if (a >= 65 && a <= 90)
            {
                a = (char)(a + 32);
                Console.WriteLine(a);
            }
            else if (a >= 97 && a <= 122)
            {
                a = (char)(a - 32);
                Console.WriteLine(a);
            }
            else
                Console.WriteLine("Enter Alphabet");

        }
    }
}
