using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Setter
{
    class Movie
    {
       
        string moviename, director, actor,actress;
        float rating;

        public Movie()
        {
            Console.WriteLine("In movie default Constructor");
        }

        public Movie(string moviename, float rating)
        {
            this.moviename = moviename;
            this.rating = rating;
            Console.WriteLine("In parameterized Constructor");
        }
        public void SetMovieName(string nm)
        {
            moviename = nm;
        }
        public string GetMovieName()
        {
            return moviename;
        }

        public void SetDirector(string d)
        {
            director = d;
        }
        public string GetDirector()
        {
            return director;
        }

        public void SetActor(string ac)
        {
            actor = ac;
        }
        public string GetActor()
        {
            return actor;
        }
        public void SetActress(string act)
        {
            actress = act;
        }
        public string GetActress()
        {
            return actress;
        }

        public void SetRating(float rate)
        {
            rating = rate;
        }
        public float GetRating()
        {
            return rating;
        }


       
    }



    class Display
    {
        static void Main(string[] args)
        {
            Movie d=new Movie();
            d.SetMovieName("Street Dancer");
            d.SetDirector("Remo");
            d.SetActor("Varun");
            d.SetActress("Shraddha");
            d.SetRating(4.5f);

            Console.WriteLine(d.GetMovieName());
            Console.WriteLine(d.GetDirector());
            Console.WriteLine(d.GetActor());
            Console.WriteLine(d.GetActress());
            Console.WriteLine(d.GetRating());



            Movie d2=new Movie();
            //string m,dir,a1,a2;

            Console.WriteLine("Enter movie name=");
            d2.SetMovieName(Console.ReadLine());
            Console.WriteLine("Enter Director name=");
            d2.SetDirector(Console.ReadLine());
            Console.WriteLine("Enter Actor=");
            d2.SetActor(Console.ReadLine());
            Console.WriteLine("Enter Actress");
            d2.SetActress(Console.ReadLine());
            Console.WriteLine("Enter Rating");
            d2.SetRating(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Movie=" +d2.GetMovieName());
            Console.WriteLine("Director=" + d2.GetDirector());
            Console.WriteLine("Actor=" + d2.GetActor());
            Console.WriteLine("Actress=" + d2.GetActress());
            Console.WriteLine("Rating=" + d2.GetRating());

            Movie d3=new Movie("DDLJ",4.3f);
        }
    }


}
