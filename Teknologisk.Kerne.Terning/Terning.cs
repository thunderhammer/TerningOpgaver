using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknologisk.Kerne
{
    public class Terning
    {
        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }


        public int Værdi { get; private set; }
        private static System.Random rnd = new System.Random();

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public string Skriv()
        {
            return $"[{this.Værdi}]";
        }




    }

    

}
