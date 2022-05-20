using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Setter
{
    class Voter
    {
        long aadhar;
        string name;
        string votercast;

        public void SetAadhar(long card)
        {
            aadhar = card;
        }
        public long GetAadhar()
        {
            return aadhar;
        }

        public void SetName(string nm)
        {
            name = nm;
        }
        public string GetName()
        {
            return name;
        }

        public void SetVoterCast(string vc)
        {
            votercast = vc;
        }
        public string GetVoterCast()
        {
            return votercast;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Voter v1=new Voter();
            v1.SetAadhar(258369147123);
            v1.SetName("Sudhir");
            v1.SetVoterCast("NCP");

            Console.WriteLine(v1.GetAadhar());
            Console.WriteLine(v1.GetName());
            Console.WriteLine(v1.GetVoterCast());
        }
    }
}
