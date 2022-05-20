using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                        // Multiplication of number from 1-10 using for loop

namespace MicrosoftBatch.March23
{
    internal class Multiplication
    {
        static void Main(string[] args)
        {
            int mult = 1;
            for(int i = 1; i <=10; i++)
            {
                mult= mult * i;
            }
            Console.WriteLine(mult);
        }
    }
}
