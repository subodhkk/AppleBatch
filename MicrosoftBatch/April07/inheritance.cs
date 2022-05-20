using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.April07
{
   

    class B11
    {
        string name;
        long accno;

        
        public string Name { get => name; set => name = value; }
        public long Accno { get => accno; set => accno = value; }
    }
    
    class HDFC:B11
    {
    float roi = 9.3f;
    }

    class ICICI:B11
    {
        float roi = 9.5f;
    }
    

    

}
