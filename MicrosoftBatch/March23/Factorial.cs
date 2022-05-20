using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.March23
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no=");
            int y = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=y;i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);

        }

        

    }
}
