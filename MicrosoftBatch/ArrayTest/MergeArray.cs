using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.ArrayTest
{
  
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr2 = { 11, 22, 33, 44 };

            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                arr3[k++] = arr1[i++];
                arr3[k++] = arr2[j++];
            }

            while (i < arr1.Length)
                arr3[k++] = arr1[i++];

            while (j < arr2.Length)
                arr3[k++] = arr2[j++];

            for(i=0; i < arr3.Length; i++)
            Console.Write(" " +arr3[i]);
        }
    }
}
