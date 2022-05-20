using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Funcation
{
    class Book
    {
        public string publication,author;
        public int mrp, edition,id; 

        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.publication = "Mehta";
            b1.author = "Robin";
            b1.mrp = 449;
            b1.edition = 3;
            b1.id = 430;
            Console.WriteLine($"publication {b1.publication} author {b1.author} Mrp {b1.mrp} Edition {b1.edition} ID {b1.id}");


            Book b2=new Book();
            Console.WriteLine("Enter Publication,Author,Mrp,Edition,id");
            b2.publication = Console.ReadLine();
            b2.author = Console.ReadLine();
            b2.mrp =Convert.ToInt32(Console.ReadLine());
            b2.edition =Convert.ToInt32(Console.ReadLine());
            b2.id= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"publication {b2.publication} author {b2.author} Mrp {b2.mrp} Edition {b2.edition} ID {b2.id}");
        }   

    }

   
}

