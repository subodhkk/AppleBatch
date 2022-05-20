using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Setter
{
    internal class AA
    {
        public static void M1()
        {
            Console.WriteLine("You are in M1");
        }

        public static void M2()
        {
            Console.WriteLine("You are in M2");
            
        }

        public void M3()
        {
            Console.WriteLine("You are in M3");
            M1();
        }

        public void M4()
        {
            Console.WriteLine("You are in M4");
            M2();
        }
    }

    class AAA
    {
        static void Main(string[] args)
        {
             AA aa = new AA();
            aa.M3();
            aa.M4();
            AA.M1();
            AA.M2();
        }
    }
}
