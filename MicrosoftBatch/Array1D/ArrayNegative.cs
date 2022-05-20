using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArrayNegative
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            //int[] neg=new int[100];
            //int[] pos=new int[100];

            int n,x=0;

            Console.WriteLine("Enter size of the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} elements in the array: ");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i]<0)
                {
                    Console.Write("  " +arr[i]);
                    x++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative Numbers in Array are= " +x);
        }
    }
}
