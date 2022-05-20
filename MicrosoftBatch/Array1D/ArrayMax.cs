using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArrayMax
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            

            int n,max = 0;

            Console.WriteLine("Enter size of the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} elements in the array: ");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min=arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element = " + max);
            Console.WriteLine();
            Console.Write("Minimum element = " + min);
        }
    }


    class ArrayMax1
    {      
       
        public static void Main()
        {
            int[] arr1 = new int[5];
         
            Console.WriteLine("Enter 5 elements");
            arr1[0]=Convert.ToInt32(Console.ReadLine());
            arr1[1]=Convert.ToInt32(Console.ReadLine());
            arr1[2]=Convert.ToInt32(Console.ReadLine());
            arr1[3]=Convert.ToInt32(Console.ReadLine());
            arr1[4]=Convert.ToInt32(Console.ReadLine());
                                 
            int max = arr1[0];

            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                    max = arr1[i];
            }
            Console.WriteLine("Largest in given " + "array is " + max);
        }
    }


}
