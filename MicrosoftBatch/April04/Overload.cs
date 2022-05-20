using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April04
{
    internal class Overload
    {
        public void Pattern(int r)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void Pattern (int r,int c,char ch)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            
        }

        static void Main(string[] args)
        {

            
            Overload ol=new Overload();
            ol.Pattern(10);
            ol.Pattern(3, 3, 'A');
        }
    }
}
