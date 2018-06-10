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
        static string sti = @"D:\Dyrenavne.txt";
        static Random R = new System.Random();

        

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder ...");
        }

        static public Dyr TilfældigtDyr()
        {
            int HundEllerKat;
            string[] navne = System.IO.File.ReadAllLines(sti);
            
            int index = R.Next(0,navne.Length);
            HundEllerKat = R.Next(0, 2);
            
            
            if (HundEllerKat == 0)
            {
                return new Hund() {Navn = navne[index]};
            }

            else
            {
                return new Kat() { Navn = navne[index] };
            }

        }


        class Hund : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine("Jeg er en hund og hedder " + Navn);
            }
        }

        class Kat : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine("Jeg er en kat og hedder " + Navn + " ...");
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
                Dyr d1 = TilfældigtDyr();

                h1.SigNoget();
                k1.SigNoget();
                h2.SigNoget();
                k2.SigNoget();
                d1.SigNoget();
                Dyr[] dyr = new Dyr[20];
                for (int i = 0; i < 20; i++)
                {
                    dyr[i] = Dyr.TilfældigtDyr();
                }

                foreach (var item in dyr)
                {
                    item.SigNoget();
                }

            }
        }
    }
}
