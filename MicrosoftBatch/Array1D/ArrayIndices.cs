using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArrayIndices
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int[] ind=new int[100];


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
                if (arr[i] == i)
                {
                    ind[i] = arr[i];
                    x++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Elements with same indices are " +x);
            /*for(int i=0;i<x;i++)
            {
                Console.Write("  " +ind[]);
            }*/
        }
    }
}
