using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April04
{
    internal class Account2
    {
        string member, custname;
        long accno;

        public Account2()
        {
            Console.WriteLine("I am in default Constructor");
        }

        public void SetMember(string m)
        {
            member = m;
        }
        public string GetMember()
        {
            return member;
        }
        public void SetCustName(string cn)
        {
            custname = cn;
        }

        public string GetCustName()
        {
            return custname;
        }
        public void SetAccNo(long an)
        {
            accno = an;
        }

        public long GetAccNo()
        {
            return accno;
        }



        static void Main(string[] args)
        {
            Account2 acc=new Account2();
            Console.WriteLine("Enter Member");
            acc.SetMember(Console.ReadLine());

            Console.WriteLine("Enter Customer Name ");
            acc.SetCustName(Console.ReadLine());

            Console.WriteLine("Enter Account Number");
            acc.SetAccNo(Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine("Member=" +acc.GetMember());
            Console.WriteLine("Customer Name " +acc.GetCustName());
            Console.WriteLine("Account Number " +acc.GetAccNo());
        }
    }
}
