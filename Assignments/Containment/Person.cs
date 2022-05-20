using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Containment
{
    internal class Person
    {
        int id;
        String name;
        Vehicle v = new Vehicle();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Vehicle V { get => v; set => v = value; }
    }

    public class Vehicle
    {
        int vid;
        String vname;

        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }
    }

    class PersonRun
    {
        static void Main(string[] args)
        {
            Person pp=new Person();
            pp.Name = "Subodh";
            pp.Id = 212;
            pp.V.Vid = 369;
            pp.V.Vname = "Honda";

            Console.WriteLine(pp.Name);
            Console.WriteLine(pp.Id);
            Console.WriteLine(pp.V.Vid);
            Console.WriteLine(pp.V.Vname);

            Person pp1=new Person();

        }
    }
}
