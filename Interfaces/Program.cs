using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kunde k = new Kunde();
            k.Gem();

            Vare v = new Vare();
            v.Gem();
        }
    }

    interface IDbfunktioner
    {
        void Gem();
        void Reset();

    }

    class Kunde : IDbfunktioner
    {
        public void Gem()
        {
            Console.WriteLine("Gemmer kunder");

        }
        public void Reset()
        {

        }
    }

    class Vare : IDbfunktioner
    {
        public void Gem()
        {
            Console.WriteLine("Gemmer varer");
        }
        public void Reset()
        {

        }
    }
}
