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
            this.Værdi = 1;
        }


        //public int Værdi { get; private set; }
        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set
            {
                if (value < 1 || value > 6)
                    this.værdi = 1;
                else
                    this.værdi = value;
            }
        }
        private static System.Random rnd = new System.Random();

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public virtual string Skriv()
        {
            return $"[{this.Værdi}]";
        }
    }


   
    
}
