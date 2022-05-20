using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                    // Addition of number from 1-10 using for loop

namespace MicrosoftBatch.March23
{
    internal class Addition
    {
        static void Main(string[] args)
        {
            int sum=0;
            for(int i = 0; i <=10; i++)
            {
                sum = sum+i;

            }
            Console.WriteLine(sum);
        }
    }
}
