using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Terning.Consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Kerne.Terning t1 = new Kerne.Terning();
            Console.WriteLine(t1.Skriv());

            Kerne.Terning t2 = new Kerne.Terning(7);
            Console.WriteLine(t2.Skriv());
            t2.Ryst();
            Console.WriteLine(t2.Skriv()); // Write on Terning

            Kerne.Bæger b = new Kerne.Bæger();
            Console.WriteLine(b.Skriv()); // Write on Bæger
            b.Ryst();
            Console.WriteLine(b.Skriv()); // Write on Bæger

        }
    }
}
