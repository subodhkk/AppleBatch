using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


                                              //C# program to create Simple Calculator using Switch

namespace Day3_assignment
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int add, sub, div, multi;
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result ;
           /* if (input_2 > input_1)
                c = input_1;
                input_1 = input_2;
                input_2 = c;*/

            
            switch (action)
            {

                case 1:
                    {
                        add = input_1 + input_2;
                        result = add;
                        Console.WriteLine("Addition is "+result);
                        break;
                    }
                case 2:
                    {
                        sub = input_1 - input_2;
                        result = sub;
                        Console.WriteLine("Substraction is " + result);
                        break;
                    }
                case 3:
                    {
                        multi = input_1 * input_2;
                        result = multi;
                        Console.WriteLine("Multiplication is " + result);
                        break;
                    }
                case 4:
                    {
                        div = input_1 / input_2;
                        result = div;
                        Console.WriteLine("Division is " + result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("----Enter valid option----");
                        break;
                    }
            }
        }
                                   
    }
}
    

