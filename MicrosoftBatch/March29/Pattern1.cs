using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.March29
{
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of rows");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no. of Columns");
            int c = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= r; i++)
            {
                for(int j = 1; j <= c; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }

        }
    }

    internal class Pattern2
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 7; i++)
            {
                for(int j=1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    internal class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 7; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    internal class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i=5;i>=1;i--)
            {
                for(int j = 5; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class Pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j <= 5; j++)
                {
                    
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=9;i=i+2)
            {
                for(int j = 1; j<=i; j =j + 2)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        internal class Pattern70
        {
            static void Main(string[] args)
            {
                for (int i=6;i>=1;i--)
                {
                    for(int sp = 1; sp <= 6 - 1; sp++)
                    {
                        Console.Write(" ");
                    }

                    for(int j = 6; j >= 1; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
