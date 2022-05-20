using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.March24
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
             int a =Convert.ToInt32(Console.ReadLine());
            int t = a;
            int sum = 0;
            while(a> 0)
            {
                int digit = a % 10;
                sum=sum+ digit;
                a = a / 10;

            }
            if (t % sum == 0)
                Console.WriteLine("Its Harshad No");
            else
                Console.WriteLine("Not harshad no");
        }

    }


    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());

            int sqr = a * a;
            while (a > 0)
            {
                int digit = a % 10;
                sqr=sqr+ digit;
                a = a / 10;

            }

        }


    }
}
