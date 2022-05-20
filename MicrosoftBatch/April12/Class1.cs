using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April12
{
   
   
        class Parent
        {
            public virtual void Greetings()
            {
                Console.WriteLine("Hello!");
            }

        public void m1()
        {
            Console.WriteLine("Hi");
        }


        }
        class Child : Parent
        {
            public override void Greetings()
            {
                
                Console.WriteLine("Saying Hello!");
            }

            public void m1()
            {
                Console.WriteLine("Bye");
            }
        }
    

    public class Class2
    {
        static void Main(string[] args)
        {
            Parent p1 = new Child();
            
            p1.Greetings();
            p1.m1();
        }
    }
}


