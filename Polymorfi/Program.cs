using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn);
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
        public override void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn + " " + Klasselokale);            
        }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
        public override void Skriv()
        {
            Console.WriteLine(Fornavn + " " + Efternavn + " " + NøgleId);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Fornavn = "Jens", Efternavn = "Hansen" };
            Elev e1 = new Elev() { Fornavn = "Anders", Efternavn = "And", Klasselokale = "Auditorium" };
            Instruktør i1 = new Instruktør() { Fornavn = "Andersine", Efternavn = "And", NøgleId = 44 };
            p1.Skriv();
            e1.Skriv();
            i1.Skriv();

            Person[] pa = new Person[3];
            pa[0] = p1;
            pa[1] = i1;
            pa[2] = e1;

            foreach (var item in pa)
            {
                item.Skriv();
            }
        }
    }
}
