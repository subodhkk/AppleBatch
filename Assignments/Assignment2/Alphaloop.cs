using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                          //Write a program to print all alphabets from a to z using for loop

namespace Assignments.Assignment2
{
    internal class Alphaloop
    {
        static void Main(string[] args)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }

        }
    }

    internal class Count1
    {
        static void Main(string[] args)
        {
            int c = 0, rem, quo = 1;
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());

            /*
            do
            {
                int b = a / 10;
                c++;
            } while (c != 0);

            Console.WriteLine(c);
           */


            while (quo != 0)
            {
                rem = a % 10;
                quo = a / 10;
                c++;
            }

            Console.WriteLine(c);

        }
    }

    internal class Evennum1
    {
        static void Main(string[] args)
        {
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("No is= " + i);
            }
        }
    }

    internal class Evensum
    {
        static void Main(string[] args)
        {

            int sum = 0;
            Console.WriteLine("Enter the number = ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= a; i += 2)
            {

                sum = sum + i;
            }
            Console.WriteLine(sum);

        }
    }

    internal class Factorialsum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no=");
            int y = Convert.ToInt32(Console.ReadLine());                         //153
            int fact = 1;
            int quo = y;
            for (int i = 1; i <= y; i++)
            {
                int sum = 0;
                while (y != 0)
                {
                    int rem = y % 10;                       //rem=3         rem=5
                    y = y / 10;                             //y=15           y=1
                    fact = fact * rem;                      //fact=3        fact=15
                    sum = sum + fact;                        //sum=3        sum=18                      
                }
                Console.WriteLine(sum);
            }

        }
    }

    internal class Oddnum
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >= 229; i--)
            {
                if (i % 2 == 1)
                    Console.WriteLine("Even no.= " + i);
            }
        }
    }

    internal class Oddsum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the number = ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i += 2)
            {

                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }

    internal class Product
    {
        static void Main(string[] args)
        {
            int num, product = 1;

            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                product = product * (num % 10);
                num = num / 10;
            }

            Console.WriteLine("Product of digits = " + product);

        }
    }

    internal class Square
    {
        static void Main(string[] args)
        {
            int sqr;
            int n = 20;

            for (int i = 1; i < 21; i++)
            {
                sqr = i * i;
                Console.WriteLine(sqr);
            }

        }
    }

    internal class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int a = Convert.ToInt32(Console.ReadLine());


            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(a + " * " + j + " = " + a * j);
            }
        }


    }
}
