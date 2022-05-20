using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array1D
{
    internal class ArrayEO
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int[] even=new int[100];
            int[] odd=new int[100];

            int n, x = 0,y=0;

            Console.WriteLine("Enter size of the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} elements in the array: ");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                if (arr[i] %2==0)
                {
                    even[x]=arr[i];
                    x++;
                }
                else
                {
                    odd[y]=arr[i];
                    y++;
                }               
            }
            Console.WriteLine();
            Console.WriteLine("Elements in EVEN array are= ");
            for (int i = 0; i < x; i++)
            {
                Console.Write("  " + even[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Elements in ODD array are= ");
            for (int i = 0; i < y; i++)
            {
                Console.Write("  " + odd[i]);
            }
        }
    }
}
