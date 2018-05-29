using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public Person()
        {
            this.Navn = "";
        }


        public String Navn { get; set; }

        public void Skriv()
        {
            Console.WriteLine("Jeg er en person, og hedder " + this.Navn);
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "a";
            p.Skriv();

            Kursist k = new Kursist();
            k.Navn = "b";
            k.Skriv();
            k.SkrivBevis();
            Instruktør i = new Instruktør() { Navn = "C" };
            i.Skriv();

            HjælpeInstruktør h = new HjælpeInstruktør() { Navn = "d" };
            h.Skriv();
        }
    }


    class Kursist : Person
    {

        public Kursist() : base()
        {
            this.Navn = " ";
            this.KursistId = "22";
        }
        public string KursistId { get; set; }

        public void SkrivBevis()
        {

        }
    }

    class Instruktør : Person
    {
        public Instruktør() :base()
        {

        }
        public DateTime Ansættelsesdato { get; set; }
        public void SkrivLønSeddel()
        {

        }
    }

    class HjælpeInstruktør : Instruktør
    {
        public HjælpeInstruktør() : base()
        {
        }


        public int Praktikperiode { get; set; }
    }
}
