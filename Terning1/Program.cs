using System;

namespace Terning1
{
    // My very own dice making program. 
    class Program
    {
        public class Terning
        {
            public Terning()
            {
                this.værdi = 1;
                this.snyd = false;
            }

            public Terning(bool snydetamp)
            {
                this.værdi = 1;
                this.snyd = true;
            }

            public int værdi;
            private bool snyd;
            private static Random rnd = new Random();

            public void Skriv()
            {
                Console.WriteLine("[" + this.værdi + "]");
            }
            
            public void Ryst()
            {
                if (snyd is false)
                    værdi = rnd.Next(1, 7);

                else
                    værdi = 6;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
        }
    }
}
