using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.March23
{
    internal class Primeno
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter the no");
             int a=Convert.ToInt32(Console.ReadLine());

             if (a % 3 == 0 || a % 5 == 0 || a % 7 == 0 || a % 11 == 0 || a % 13 == 0 || a % 17 == 0)
                 Console.WriteLine("Number is not PRIME NUMBER");
             else
                 Console.WriteLine("Number is PRIME NUMBER");*/
            
            //  Using for loop

            Console.WriteLine("Enter the Number=");
            int n=Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int div=1;div<=n; div++)
            {
                if(n%div==0)
                {
                    //Console.WriteLine(div);
                    c++;
                }
            }
            if (c == 2)
                Console.WriteLine("Number is PRIME");
            else
                Console.WriteLine("Not a PRIME");

           /* Console.WriteLine("Enter the Number=");
            int n=Convert.ToInt32(Console.ReadLine());
            int flag= 10;
            for(int i=2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    flag=1;
                }
            }
            if(flag==10)
                Console.WriteLine("Number is Prime");
            else
                Console.WriteLine("Number is Prime");*/
            

        }
    }
}
