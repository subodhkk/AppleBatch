using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April06
{
    class Flat
    {
               
        int flatno;
        string buildingname;
        Owner flatowner = new Owner();

       

        public int Flatno { get => flatno; set => flatno = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
        internal Owner Flatowner { get => flatowner; set => flatowner = value; }
    }
        
    class Owner
    {
        string ownername;
        int age;
        string profession;
        char gender;

        public string Ownername { get => ownername; set => ownername = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }
        public char Gender { get => gender; set => gender = value; }
    }
    class FlatTest
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Flatno= 101;
            f1.Buildingname= "SDSSD";
        }

    }

}
