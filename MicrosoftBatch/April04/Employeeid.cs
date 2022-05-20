using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April04
{
    internal class Employeeid
    {
        int id, salary;
        string name;

        public void SetName(String nm)
        {
            name = nm;
        }

        public string GetName()
        {
            return name;
        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }
        public void SetSalary(int sal)
        {
            salary = sal;
        }

        public int GetSalary()
        {
            return salary;
        }



        static void Main(string[] args)
        {
            Employeeid ei=new Employeeid();

            Console.WriteLine("Enter Employee id ");
            ei.SetId(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter Employee Name ");
            ei.SetName(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary ");
            ei.SetSalary(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("---------------------------------");
            Console.WriteLine("ID= " +ei.GetId());
            Console.WriteLine("Name= " +ei.GetName());
            Console.WriteLine("Salary= " +ei.GetSalary());


        }
    }
}
