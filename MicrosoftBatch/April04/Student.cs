using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April04
{
    internal class Student
    {
        private int age, percent;
        private string name;

        public static void Name(string n)
        {
            Console.WriteLine("Name- " +n);
        }
        public  static void Age(int a)
        {
            Console.WriteLine("The Age is- " +a);
           
        }
        public static void Percent(int p)
        {
            Console.WriteLine("Percent Got- " +p);   
        }     
            
    }

    class Test
    {
        static void Main(string[] args)
        {
            //Student st = new Student();
            Student.Name("Akash");
            Student.Age(25);
            Student.Percent(62);
           
        }
    }
}
