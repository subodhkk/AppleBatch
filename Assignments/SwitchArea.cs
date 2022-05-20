using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class SwitchArea
    {
        static void Main(string[] args)
        {
            float area, cir;
            Console.WriteLine("Press 1 for area of Circle");
            Console.WriteLine("Press 2 for area of Square");
            Console.WriteLine("Press 3 for area of right angled triangle");
            Console.WriteLine("Press 4 for area of Rectangle");
            Console.WriteLine("Press 5 for circumference of Circle");
            Console.WriteLine("Press 6 for Perimeter of Square");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:        //Area of circle
                    Console.WriteLine(" Enter the Radius= ");
                    float r = Convert.ToSingle(Console.ReadLine());
                    area = 3.14f * r * r;
                    Console.WriteLine("Area of Circle is= " + area);
                    break;

                case 2:       //Area of Square 
                    Console.WriteLine(" Enter the side of Square= ");
                    float s = Convert.ToSingle(Console.ReadLine());
                    area = s * s;
                    Console.WriteLine("Area of Square is= " + area);
                    break;

                case 3:        //Area of right angled triangle
                    Console.WriteLine("Enter the lenght of BASE and HEIGHT");
                    float b = Convert.ToSingle(Console.ReadLine());
                    float h = Convert.ToSingle(Console.ReadLine());
                    area = 0.5f * b * h;
                    Console.WriteLine("Area of right angled triangle is= " + area);
                    break;

                case 4:        //Area of Rectangle
                    Console.WriteLine("Enter LENGTH and BREADTH of Rectangle");
                    int lenght = Convert.ToInt32(Console.ReadLine());
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    area = lenght * breadth;
                    Console.WriteLine("Area of Rectangle is= " + area);
                    break;

                case 5:        //Circumference of circle
                    Console.WriteLine(" Enter the radius");
                    float radius = Convert.ToSingle(Console.ReadLine());
                    cir = 2 * 3.14f * radius;
                    Console.WriteLine("Circumference of circle is= " + cir);
                    break;

                case 6://Perimeter of square
                    Console.WriteLine("Enter the side of square");
                    int side = Convert.ToInt32(Console.ReadLine());
                    int peri = 4 * side;
                    Console.WriteLine("Perimeter of square is= " + peri);
                    break;

                default:
                    Console.WriteLine("Enter valid Option");
                    break;
            }

        }
    }
}
