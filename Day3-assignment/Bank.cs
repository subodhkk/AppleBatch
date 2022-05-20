using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_assignment
{
    internal class Bank
    {
        static void Main(string[] args)
        {
            int amount, tt, fh, th, h, f, t, ten, one;
            Console.WriteLine("Enter the value");
            amount=Convert.ToInt32(Console.ReadLine());                     //5683
            tt = amount / 2000;                                             //tt= 2
            int rem1 = amount % 2000;                                       //rem1= 1683
            fh = rem1 / 500;                                                //fh=3
            int rem2= rem1 % 500;                                           //rem2=183
            th = rem2 / 200;                                                //th=0
            int rem3= rem2 % 200;                                           //rem3=183
            h = rem3 / 100;                                                  //h=1
            int rem4= rem3 % 100;                                           //rem4= 83
            f = rem4 /50;                                                   //f=1
            int rem5= rem4 % 50;                                            //rem5= 33
            t = rem5 / 20;                                                  //t= 1
            int rem6= rem5 % 20;                                            //rem6= 13
            ten = rem6 / 10;                                                //ten= 1
            int rem7= rem6 % 10;                                            //rem7= 3
            one = rem7 / 1;                                                 //one= 3

            Console.WriteLine("The total no of Rs 2000 note/s is/ are= " + tt);
            Console.WriteLine("The total no of Rs 500 note/s is/ are= " + fh);
            Console.WriteLine("The total no of Rs 200 note/s is/ are= " + th);
            Console.WriteLine("The total no of Rs 100 note/s is/ are= " + h);
            Console.WriteLine("The total no of Rs 50 note/s is/ are= " + f);
            Console.WriteLine("The total no of Rs 20 note/s is/ are= " + t);
            Console.WriteLine("The total no of Rs 10 note/s is/ are= " + ten);
            Console.WriteLine("The total no of Rs 1 note/s is/ are= " + one);

        }
    }
}
