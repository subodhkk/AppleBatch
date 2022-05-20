using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.March29
{
    internal class PatternA
    {
        static void Main(string[] args)
        {
            //       6
            //      56
            //     456
            //    3456
            //   23456
            //  123456
           
            for (int i = 6; i >= 1; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 6; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
               // m++;
            }
        }
    }  
    

    internal class PatternB
    {
        //*
        //***
        //*****
        //*******
        //*********

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of Rows");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >= 1; i--);
            {
                for (int k = 1; k <= (n * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }

    
}
