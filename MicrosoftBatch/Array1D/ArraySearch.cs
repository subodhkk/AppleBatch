using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArraySearch
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int num;

            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {num} elements in the array: ");

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in arr)
                Console.Write("  " + i);

            Console.WriteLine("Enter the Search Element");
            int s=Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                if(arr[i] == s)
                {
                    Console.WriteLine("Element found at position " +i);
                }
            }
        }
    }
}
