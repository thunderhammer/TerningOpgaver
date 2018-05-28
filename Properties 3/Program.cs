using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_3
{

    class Triangle
    {


        public int Grundlinie { get; }
        public int Højde { get; }

        public Triangle(int grundlinie, int højde)
        {
            this.Grundlinie = grundlinie;
            this.Højde = højde;
        }

        /*public int Areal() 
        {
            return ((Højde * Grundlinie)/2);
        }*/ /* As a method call */
        public double Areal /* As a property */
        {
            get { return ((Højde * Grundlinie) * 0.5); }
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(5, 10);
            Console.WriteLine(t1.Areal.ToString());

        }
    }
}
