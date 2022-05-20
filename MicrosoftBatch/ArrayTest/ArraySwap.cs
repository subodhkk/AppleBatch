using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.ArrayTest
{
    internal class ArraySwap
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
                        
            Console.WriteLine($"Enter 10 elements in the array: ");

            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


        }
    }
}
