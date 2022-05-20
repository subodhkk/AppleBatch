using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.StringClass
{
    internal class LongestString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string line");
            string? s= Console.ReadLine();
            string[] s1= s.Split(" ");
            int l1 = s1.Length;
            string w = "";
            int c = 0;
            for (int i=0;i<l1-1;i++)
            {
                for(int j=1;j<l1-1;j++)
                {
                    if (s1[i].Length > s1[j].Length)
                    {
                        w = s1[i];  

                    }
                    else
                    {
                        w = s1[j];
                    }
                }
            }
            Console.WriteLine(w);
            
        }
    }
}
