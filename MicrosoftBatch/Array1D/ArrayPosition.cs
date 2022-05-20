using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArrayPosition
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int n, pos, x;

            Console.WriteLine("Enter size of the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} elements in the array: ");
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the element to be inserted");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Position of inserted element");
            pos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                if (i < pos - 1)
                    arr[i] = arr[i];
                else if (i == pos - 1)
                    arr[i] = x;
                else
                    arr[i] = arr[i - 1];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("  " + arr[i]);
            }
        }
    }
}
