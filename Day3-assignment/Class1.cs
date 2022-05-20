using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_assignment
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            float commi;
            Console.WriteLine("Sales Made");
            int sales =Convert.ToInt32(Console.ReadLine());

            if (sales>0 && sales <= 10000 )
            {

                commi = sales * 0.01f;
                Console.WriteLine("Commission is=" + commi);
            }
            else if (sales>10000 && sales<=20000)
            {
                commi = sales * 0.02f;
                Console.WriteLine("Commission is =" + commi);

            }
            else
                Console.WriteLine("sales is above 20000");

        }
    }
}
