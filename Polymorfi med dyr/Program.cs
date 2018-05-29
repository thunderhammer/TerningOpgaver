using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi_med_dyr
{
    abstract class Dyr
    {
        public string Navn { get; set; }
        static string sti = @"X:\dyrenavne.txt";
        

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder ...");
        }

        static public Dyr TilfældigtDyr()
        {
            int HundEllerKat;
            string[] navne = System.IO.File.ReadAllLines(sti);
            Random R = new System.Random();
            HundEllerKat = R.Next(0, 2);



            if (HundEllerKat == 0)
            {
                return new Hund() { };
            }

            else
            {
                return new Kat() { };
            }

        }


        class Hund : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine("Jeg er en hund og hedder ...");
            }
        }

        class Kat : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine("Jeg er en kat og hedder ...");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Hund h1 = new Hund();
                Hund h2 = new Hund();
                Kat k1 = new Kat();
                Kat k2 = new Kat();

                h1.SigNoget();
                k1.SigNoget();
                h2.SigNoget();
                k2.SigNoget();

            }
        }
    }
}
