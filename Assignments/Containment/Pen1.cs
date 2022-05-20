using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Containment
{
        internal class Pen1
        {
            int capLength;
            string brand;
            Refill r = new Refill();
            Nib n = new Nib();

            public int CapLength { get => capLength; set => capLength = value; }
            public string Brand { get => brand; set => brand = value; }
            internal Nib N { get => n; set => n = value; }
            internal Refill R { get => r; set => r = value; }
        }
        public class Refill
        {
            string inkColor;
            int length;
           

            public string InkColor { get => inkColor; set => inkColor = value; }
            public int Length { get => length; set => length = value; }
            
        }
        public class Nib
        {
            string materialType;
            int width;

                public string MaterialType { get => materialType; set => materialType = value; }
                public int Width { get => width; set => width = value; }
        }
    

    class PenRun
    {
        static void Main(string[] args)
        {
            Pen1 p= new Pen1();
            p.CapLength = 2;
            p.Brand = "Linc";
            p.R.InkColor = "Black";
            p.R.Length = 10;
            p.N.Width = 10;
            p.N.MaterialType = "Copper";


            Console.WriteLine(p.CapLength);
            Console.WriteLine(p.Brand); 
            Console.WriteLine(p.R.InkColor);
            Console.WriteLine(p.R.Length);
            Console.WriteLine(p.N.Width);
            Console.WriteLine(p.N.MaterialType);
        }
    }
}
