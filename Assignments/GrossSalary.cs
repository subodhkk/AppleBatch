using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class GrossSalary
    {
        static void Main(string[] args)
        {
            float GS;
            Console.WriteLine(" Your Basic Salary ");
            int bs = Convert.ToInt32(Console.ReadLine());

            if (bs > 0 && bs <= 10000)
            {
                //hRA = bs * 0.02f;
                //DA = bs * 0.08f;
                GS = bs + (bs * 0.02f) + (bs * 0.08f);
                Console.WriteLine(" Gross salary is = " + GS);
            }
            else if (bs > 10000 && bs <= 20000)
            {
                GS = bs + (bs * 0.025f) + (bs * 0.09f);
                Console.WriteLine(" Gross salary is = " + GS);
            }
            else if (bs > 20000)
            {
                GS = bs + (bs * 0.03f) + (bs * 0.095f);
                Console.WriteLine(" Gross salary is = " + GS);
            }

            else
                Console.WriteLine(" Enter valid Amount ");
        }
    }
}
