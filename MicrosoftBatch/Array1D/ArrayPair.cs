using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArrayPair
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
            Console.WriteLine("Enter the sum you want");
            int sum=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num;i++)
            {
                for(int j=i+1;j<num; j++)
                {
                    if(arr[i]+arr[j]==sum)
                        Console.WriteLine($"Pair of the element of sum {sum} are {arr[i]} & {arr[j]} ");
                }
            }

        }
    }
}
