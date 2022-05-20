using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April06
{
    class Order
    {

        int orderid;
        string orderdate;
        Customer c=new Customer();
        Item i=new Item();

        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        internal Customer C { get => c; set => c = value; }
        internal Item I { get => i; set => i = value; }
    }

    class Customer
    {
        string custname;
        int age;
        char gender;
        Address ad1=new Address();
        

        public string Custname { get => custname; set => custname = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        internal Address Ad1 { get => ad1; set => ad1 = value; }
       
    }

    class Address
    {
        string street;
        string city;
        string state;
        int pincode;

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }

    class Item
    {
        int itemid;
        string name;
        string brand;
        int mrp;

        public int Itemid { get => itemid; set => itemid = value; }
        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Mrp { get => mrp; set => mrp = value; }
    }



    class OrderTest
    {
        static void Main(string[] args)
        {
            Order o1=new Order();
            o1.Orderid = 1;
            o1.Orderdate = "April22";
            o1.C.Custname = "Raj";
            o1.C.Age = 22;
            o1.I.Itemid = 101;
            o1.I.Name = "Cloths";
            o1.I.Mrp = 2000;
            o1.C.Ad1.City = "Kolhapur";
            o1.C.Ad1.Street = "Rajwada";
            o1.C.Ad1.State = "Maharashtra";
            o1.C.Ad1.Pincode = 416101;


            Console.WriteLine(o1.Orderdate);
            Console.WriteLine(o1.C.Custname);
            Console.WriteLine(o1.C.Ad1.Street);
        }
    }

}
