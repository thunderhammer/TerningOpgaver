using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelKortSpil
{
    class Program
    {
        static void Main(string[] args)
        {
            SpilleKort s1 = new SpilleKort(9, Kulør.Klør);
            Console.WriteLine(s1.Print());
            
            for (int i = 0; i < 100; i++)
            {
                SpilleKort s2 = SpilleKort.TilfældigtKort();
                if (s2.FindFarve() == Farve.Rød)
                    Console.ForegroundColor = ConsoleColor.Red;

                else if (s2.FindFarve() == Farve.Sort)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine(s2.Print());
            }

        }
    }
}
