using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.March23
{
    internal class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Base");                    //8
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Power");                   //3
            int p = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i<= p; i++)
            {
                sum = b * p;
            }
            Console.WriteLine(sum);
        }
    }
}
