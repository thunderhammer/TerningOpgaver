using System;

namespace Delegate
{
    class Program
    {

        public delegate int Beregn(int a, int b);
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            int res = Beregner(1, 1, Plus);
            Console.WriteLine("Resultatet er " + res);

            int res2 = Beregner(1, 1, Minus);
            Console.WriteLine("Resultatet er " + res2);

            int res3 = Beregner(1, 1, Gange);
            Console.WriteLine("Resultatet er " + res3);


        }


        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static int Beregner(int a, int b, Beregn c)
        {
            return c(a,b);
        }
        

    }
}
