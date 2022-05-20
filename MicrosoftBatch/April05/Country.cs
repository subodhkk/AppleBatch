using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April05
{
    class Country
    {
        string cname, capital;
        int noofstate, nooflang;

        public Country(string cn, string cap, int nos, int nol)
        {
            cname = cn;
            capital = cap;
            noofstate = nos;
            nooflang = nol;
        }
        public Country()
        {
            Console.WriteLine("In Default");
        }


        public string Cname
        {

            set { cname = value; }
            get { return cname; }
        }
        public string Capital
        {

            set { capital = value; }
            get { return capital; }
        }

        public int Noofstate
        {
            get { return noofstate; }
            set { noofstate = value; }
        }

        public int Nooflang
        {
            get { return nooflang; }
            set { nooflang = value; }
        }
    }

        class Country1
        {
            static void Main(string[] args)
            {
                Country c1 = new Country();
                c1.Cname = "India";
                c1.Capital = "Delhi";
                c1.Nooflang = 200;
                c1.Noofstate = 28;

                Console.WriteLine(c1.Cname);
                Console.WriteLine(c1.Capital);
                Console.WriteLine(c1.Nooflang);
                Console.WriteLine(c1.Noofstate);


            }
        }
    
}
