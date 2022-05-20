using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Containment
{
    internal class Teacher
    {
        int tid;
        long mobile;
        string nm;
        HourlyBased hb = new HourlyBased();
        SalaryBased sb =new SalaryBased();
                
                
        public Teacher()
        {

        }

        public Teacher(int tid, long mobile, string nm)
        {
            this.tid = tid;
            this.mobile = mobile;
            this.nm = nm;
        }

        public Teacher(int tid, long mobile, HourlyBased hb, SalaryBased sb)
        {
            this.tid = tid;
            this.mobile = mobile;
            this.Nm = Nm;
            this.hb = hb;
            this.sb = sb;


        }

        public int Tid { get => tid; set => tid = value; }
        public long Mobile { get => mobile; set => mobile = value; }
        public string Nm { get => nm; set => nm = value; }
        internal HourlyBased Hb { get => hb; set => hb = value; }
        internal SalaryBased Sb { get => sb; set => sb = value; }
    }




    class HourlyBased:Teacher
    {
        private static long mobile;
        private static int tid;
        private static string nm;
        int sal;
        int rph;
        int hrs;
       
        public HourlyBased()
        {

        }
        public HourlyBased(int sal, int rph, int hrs):base(tid,mobile,nm)
        {
            this.sal = sal;
            this.rph = rph;
            this.hrs = hrs;

            sal = rph * hrs;
            
        }

        public int Sal { get => sal; set => sal = value; }
        public int Rph { get => rph; set => rph = value; }
        public int Hrs { get => hrs; set => hrs = value; }
       
    }
    class SalaryBased:Teacher
    {
        SalaryBased sb = new SalaryBased();
        public SalaryBased()
        {

        }
        int salary;

        public SalaryBased(int salary)
        {
            this.Salary = salary;

        }

        public int Salary { get => salary; set => salary = value; }



        class TeacherRun
        {
            static void Main(string[] args)
            {
                Teacher t = new Teacher();
                t.Tid = 202;
                t.Mobile = 9874561230;
                t.Nm = "Sk";
                t.Hb.Hrs = 2;
                t.Hb.Rph = 500;
                t.Sb.Salary = 50000;
            }
        }
    }

}



