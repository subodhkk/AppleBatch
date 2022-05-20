using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArrayCopy
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int num;

            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {num} elements in the array: ");

            for (int i = 0; i < num; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                arr2[i] = arr1[i];
            }
            
            Console.WriteLine("Elements in Original Array1 ");
            for (int i = 0; i < num; i++)
            {
                Console.Write("  " +arr1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Elements in Copied Array2 ");
            for (int i = 0; i < num; i++)
            {
                Console.Write("  " + arr2[i]);
            }
        }
    }
}
