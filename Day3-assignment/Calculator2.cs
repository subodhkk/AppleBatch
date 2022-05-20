using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                                //C# program to create Simple Calculator.

namespace Day3_assignment
{
    internal class Calculator2
    {
        static void Main(string[] args)
        {
            float add, sub, div, multi;
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            float action = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            float input_1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            float input_2 = Convert.ToSingle(Console.ReadLine());
            
            if (action == 1)
            {
                add=input_1 + input_2;
                Console.WriteLine(" Addition is = " + add);
            }
            else if (action == 2)
            {
                sub = input_1 - input_2;
                Console.WriteLine(" Substraction is = " + sub);
            }
            else if(action == 3)
            {
                multi = input_1 * input_2;
                Console.WriteLine(" Multiplication is = " + multi);
            }
            else if (action == 4)
            {
                div = input_1 / input_2;
                Console.WriteLine(" Division is = " + div);
            }

        }
    }
}
