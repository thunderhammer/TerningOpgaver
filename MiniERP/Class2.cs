using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    class InvoiceLine
    {
        public int Antal { get; set; }
        public string Tekst { get; set; }
        public double Pris { get; set; }

        public double SamletPris()
        {
            return this.Antal * this.Pris;
        }

    }
}
