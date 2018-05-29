using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Person
    {
        public String Fornavn { get; set; }
        public String Efternavn { get; set; }


        public string FuldtNavn()
        {
            return (this.Fornavn + " " + this.Efternavn);
            
        }

        static void Main(string[] args)
        {
            Person p = new Person() { Fornavn = "Morten", Efternavn = "Engemand" };
            Elev e = new Elev() { Fornavn = "Jens", Efternavn = "Hansen", Klasselokale = "B1" };
            Instruktør i = new Instruktør() { Fornavn = "Anders", Efternavn = "And", NøgleId = 5 };
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(i.FuldtNavn() + " " + i.NøgleId);
            Console.WriteLine(e.FuldtNavn().ToString());
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
