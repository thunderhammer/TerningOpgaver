using System;
using System.Collections.Generic;

namespace MoreCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bunke b = new Bunke();
            b.TilFøjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilFøjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilFøjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.VisKort();            
            Console.WriteLine(".......");
            Console.WriteLine(b.FjernKort());
            Console.WriteLine(".......");
            b.VisKort();


        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }


    class Bunke
    {
        Stack<Kort> stack = new Stack<Kort>();


        public void TilFøjKort(Kort k)
        {
            stack.Push(k);           
        }

        public void VisKort()
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public Kort FjernKort()
        {
            if (stack.Count > 0)
                return stack.Pop();
            return null;            
        }

    }
}
