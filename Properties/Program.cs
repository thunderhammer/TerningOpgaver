using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        public class Vare
        {
            private string navn;
            private double pris;

            private int myVar;

            public String Navn
            {
                get { return navn; }
                set { navn = value; }
            }

               public double Pris
            {
                get { return pris; }
                set { pris = value; }
            }

            public Vare()
            {
                navn = "";
                pris = 0;
            }

            public Vare(string navn, double pris)
            {
                this.navn = navn;
                this.pris = pris;
            }

            public void PrisMedMoms(string navn, double pris)
            {                
                this.pris = pris;
                this.navn = navn;
              

            }

            public void PrisMedMoms()
            {

            }

        }


        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.PrisMedMoms("Bil", 240000);
            Console.WriteLine(v1.Navn);
            Console.WriteLine(v1.Pris);
            

            Vare v2 = new Vare("Trabant", 2400);
            v2.PrisMedMoms();
            Console.WriteLine(v2.Navn);
            Console.WriteLine(v2.Pris);
        }
    }
}
