using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Patterns
{
    //1
    //12
    //123
    //1234
    //12345
    internal class P1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class P2
    {
        //A
        //AB
        //ABC
        //ABCD
        //ABCDE
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class P3
    {
        //*
        //**
        //***
        //****
        //*****

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    internal class P4
    {
        //1
        //22
        //333
        //4444
        //55555
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    internal class P5
    {
        //A
        //BB
        //CCC
        //DDDD
        //EEEEE
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    internal class P6
    {
        //    *
        //   **
        //  ***
        // ****
        //*****
        static void Main(string[] args)
        {
            int m = 1;
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i-1; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= m; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                m++;
            }
        }
    }

    internal class P7
    {
        //     1
        //    1 2 
        //   1 2 3
        //  1 2 3 4
        // 1 2 3 4 5 
        static void Main(string[] args)
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class P8
    {
        //    5
        //   4 5 
        //  3 4 5 
        // 2 3 4 5 
        //1 2 3 4 5 
        static void Main(string[] args)
        {
            int rows = 5;

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= rows; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class P11
    {
        //    *
        //   ***
        //  *****
        // ******* 
        //*********
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int n =Convert.ToInt32(Console.ReadLine()); 
            int m = n;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                m--;

                Console.WriteLine();
            }
        }
    }
    
    internal class P14
    {
        //12345
        //1234
        //123
        //12
        //1
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class P15
    {
        //54321
        //5432
        //543
        //54
        //5
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class P16
    {

        //5
        //54
        //543
        //5432
        //54321
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class P18
    {

        //ABCDE
        //ABCD
        //ABC
        //AB
        //A
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }



    //1
    //2 3
    //4 5 6
    //7 8 9 10
    //11 12 13 14 15
    

}
