using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.March23
{
    internal class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < a; i++)
            {
                if(a%i == 0)
                    Console.WriteLine(i);
            }

        }
    }
}
