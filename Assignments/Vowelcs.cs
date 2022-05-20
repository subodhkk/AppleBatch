using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicrosoftBatch.April06;

namespace Assignments
{
    internal class Vowel
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter the Alphabet");
            char ch = Convert.ToChar(Console.Read());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine("!! ENTERED ALPHABET IS A VOWEL !!");
            else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
                Console.WriteLine(ch + "  is a Consonent");
            else
                Console.WriteLine(" !! Enter the Alphabet !! ");

        }
    }

    
}
