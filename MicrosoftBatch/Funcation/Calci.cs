using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MicrosoftBatch.Funcation
{
    class Calci
    {
        public void Add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
            //return sum;
        }

        public float Simple(int p, float r, int n)
        {
            float si = p * r * n;
            return si;
        }

        public bool Leapyear(int y)
        {
            if(y%4==0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Calci c=new Calci();
            float r=c.Simple(500, 5.6f, 5);
            bool t = c.Leapyear(2020);
            c.Add(52, 22);


            Console.WriteLine("SIMPLE  INTREST="+r);
            Console.WriteLine("Leap Year=" + t);

            //Class2 = new Class2();
        }
    }


}
