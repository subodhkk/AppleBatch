using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Array2D
{
    internal class Array1
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Elements In row");
            int row=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Column"); 
            int col=Convert.ToInt32(Console.ReadLine());    
            int[,] a1 = new int[row, col];

           
            for(int r = 0; r < a1.GetLength(0); r++)
            {
                Console.WriteLine($"Enter row {r} " );
                for (int c = 0; c < a1.GetLength(1); c++)
                {
                    Console.WriteLine($"Enter column {c} ");
                    a1[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
           
            
            
            for (int r = 0; r < a1.GetLength(0); r++)
            {
                Console.WriteLine();
                for (int c = 0; c < a1.GetLength(1); c++)
                {
                    Console.Write("   " + a1[r, c]);
                }
            }

        }
    }
}
