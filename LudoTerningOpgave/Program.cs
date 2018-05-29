using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknologisk.Kerne;

namespace LudoTerningOpgave
{
    class LudoTerning : Teknologisk.Kerne.Terning
    {
        public LudoTerning() : base()
        {

        }

        public LudoTerning(int værdi) : base()
        {

        }


        public bool ErGlobus(int værdi)
        {
            if (værdi == 3)
                return true;
            else
                return false;
        }

        public bool ErStjerne(int værdi)
        {
            if (værdi == 5)
                return true;
            else
                return false;
        }

        public override string Skriv()
        {
            switch (this.Værdi)
            {
                case 3:
                    return ("[S]");
                    

                case 5:
                    return ("[G]");
                  

                default:
                    return base.Skriv();                    
            }
            
        } 

        class Program
        {
            static void Main(string[] args)
            {
                Terning t1 = new Terning();
                LudoTerning l1 = new LudoTerning();
                Console.WriteLine(t1.Skriv());
                Console.WriteLine(l1.Skriv());

            }
        }
    }

}
