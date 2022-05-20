using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April05
{
    internal class Stock
    {
        float stockprice, stockclose;string stockname;
        public Stock()
        {        }

        public Stock(float op,float cp,string sn)
        {
            stockprice = op;
            stockclose = cp;
            stockname = sn;
        }

        public string Stockname
        { get { return stockname; } set { stockname = value; } }

        public float Stockprice
        { get { return stockprice; } set { stockprice = value; } }

        public float Stockclose
        { 
            get { return stockclose; } 
          set { stockclose = value; } 
        }

        
    }

    class Stock1
    {
        static void Main(string[] args)
        {
            Stock s1=new Stock();
            s1.Stockname = "Aditya Birla";
            s1.Stockprice = 140.23f;
            s1.Stockclose = 136.50f;



            Console.WriteLine("Stock Name= " + s1.Stockname);
            Console.WriteLine("Opening Price= " +s1.Stockprice);
            Console.WriteLine("Closing Price= " +s1.Stockclose);
        }
    }
}
