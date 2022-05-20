using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArrayAdd
    {
        static void Main()
        {
            int[] arr = new int[100];
            int num, sum = 0;
                        
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {num} elements in the array: ");

            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

                    
            for (int i = 0; i < num; i++)
            {
                sum = sum + arr[i]; 
            }

            Console.WriteLine("Sum of all elements of array: " + sum);
                        
        }

    }
}
