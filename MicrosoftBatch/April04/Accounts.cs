using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April04
{
    class Accounts
    {
        int accdata, deposit, withdraw, checkbal;
        string accinfo;

        public void SetAccData(int a)
        {
            accdata = a;
        }
        public int GetAccData()
        {
            return accdata;
        }
        public void SetAccInfo(string acin)
        {
            accinfo = acin;
        }
        public string GetAccInfo()
        {
            return accinfo;
        }

        public void SetDeposit(int depo)
        {
            deposit = depo;
        }
        public int GetDeposit()
        {
            return deposit;
        }

        public void SetWithdraw(int wd)
        {
            withdraw = wd;
        }
        public int GetWithdraw()
        {
            return withdraw;
        }

        public void SetCheckBal(int ck)
        {
            checkbal = ck;
        }
        public int GetCheckBal()
        {
            return checkbal;
        }
    }       



    class Account1
    {
        static void Main(string[] args)
        {
            Accounts a=new Accounts();
            a.SetAccData(235);
            a.SetAccInfo("Saving");
            a.SetDeposit(5000);
            a.SetWithdraw(500);
            a.SetCheckBal(4500);

            Console.WriteLine("Data "+ a.GetAccData());
            Console.WriteLine("Info " +a.GetAccInfo());
            Console.WriteLine("Deposite Amount " +a.GetDeposit());
            Console.WriteLine("Withdraw Amount " +a.GetWithdraw());
            Console.WriteLine("Balance Remain " +a.GetCheckBal());

        }
    }
}
