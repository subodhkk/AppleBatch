using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April05
{
    internal class Pen
    {
        public Pen()
        {
            //string brand, color; int price;
        }
        string brand, color;int price;
        public Pen(string b,string c,int p)
        {
            brand= b;
            color= c;
            price= p;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }   
            set { color = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    class Pen1
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.Brand = "Linc";
            p1.Color = "Black";
            p1.Price = 40;

            Console.WriteLine("Pen= " +p1.Brand);
            Console.WriteLine("Color= " +p1.Color);
            Console.WriteLine("MRP= " +p1.Price);

        }
    }
}
