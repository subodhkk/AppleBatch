using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April14
{
    internal class Merge
    {
        
        static void Main(string[] args)
        {
            int[] a = {1,22,3,4,5};
            int[] b = {6,7,8,9,10};
            int []c=new int[a.Length + b.Length];

            int x = 0;

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
                x++;
            }
            for (int i = x, j=0; j < b.Length;i++, j++)
            {
                    c[i] = b[j];
            }
                
            for(int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            
            
        }
    }


    class Merge2
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 22, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];

            int x = 0;
            int y = 1;
            for(int i = 0; i < a.Length; i++)
            {
                c[x]=a[i];
                c[y]=b[i];
                x = x+2;
                y = y+2;
               
            }
            for (int k = 0; k < c.Length; k++)
            {
                Console.WriteLine(c[k]);
            }

        }
    }


    class Merge3
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 22, 3, 4, 5,44,55,66 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];

            int x = 0;
            int y = 1;

           for(int i = 0; i < c.Length;)
           {
                if(x<a.Length && x<b.Length)
                {
                    c[i]=a[x];
                    i++;
                    c[i]=b[x];
                    i++;
                }
                else if(x<a.Length)
                {
                    c[i] = a[x];
                    i++;

                }
                else
                {
                    c[i] = b[x];
                    i++;
                }
                x++;
                                
           }
           for(int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
