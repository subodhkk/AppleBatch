using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.StringClass
{
    internal class String1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string? s = Console.ReadLine();

            for(int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }

            Console.WriteLine();
            for(int i = s.Length-1; i>=0; i--)
            {
                Console.Write(s[i]);
            }
        }

    }
}
