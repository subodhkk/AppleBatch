using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                            // Sum of 58 & 76

namespace MicrosoftBatch.March21
{
    internal class Sum2digit

    {
        static void Main(string[] args)
        {
            int a = 5876, rem1, quo, sum;
            rem1 = a % 100;
            quo = a / 100;
            sum = rem1 + quo;
            Console.WriteLine("Sum= " + sum);

        }
    }
}
