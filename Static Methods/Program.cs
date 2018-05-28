using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Methods
{
    static class ArealBeregninger
    {
        static public double BeregnArealFirkant(double højde, double bredde)
        {
            return (højde * bredde);
        }

        static public double BeregnArealCirkel (double radius)
        {
            return (System.Math.Pow(radius, 2) * System.Math.PI);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10, 10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
        }
    }
}
