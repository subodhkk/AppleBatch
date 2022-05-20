using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April06
{
        class Student
        {
            int stuid;
            string name;
            int percent;
            Batch batch1 = new Batch();
            Address1 addr = new Address1();

            public Student()
            {

            }

            public Student(int stuid, string name, int percent, Batch batch1, Address1 addr)
            {
                this.Stuid = stuid;
                this.Name = name;
                this.Percent = percent;
                this.Batch1 = batch1;
                this.Addr = addr;
            }


            public int Stuid { get => stuid; set => stuid = value; }
            public string Name { get => name; set => name = value; }
            public int Percent { get => percent; set => percent = value; }
            public Address1 Addr { get => addr; set => addr = value; }
            public Batch Batch1 { get => batch1; set => batch1 = value; }
        }

        class Batch
        {
            string batchname;
            string subject;

            public Batch()
            {

            }
            public Batch(string batchname, string subject)
            {
                this.batchname = batchname;
                this.Subject = subject;
            }

            public string Batchname1 { get => batchname; set => batchname = value; }
            public string Subject { get => subject; set => subject = value; }
        }

        class Address1
        {
            string street, city;
            public Address1()
            {

            }

            public Address1(string street, string city)
            {
                this.Street = street;
                this.City = city;
            }

            public string Street { get => street; set => street = value; }
            public string City { get => city; set => city = value; }
        }


        class STest
        {
            static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.Stuid = 200;
                s1.Name = "Subodh";
                s1.Percent = 80;
                s1.Batch1.Batchname1 = "Apple";
                s1.Batch1.Subject = "Java";
                s1.Addr.Street = "G Road";
                s1.Addr.City = "Kolhapur";

            }
        }
    
}
