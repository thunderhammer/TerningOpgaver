using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    class Invoice
    {
        public DateTime Dato { get; set; }
        public int FakturaNummer { get; set; }
        public Customer Customer { get; set; }

        private InvoiceLine[] invoiceLines;
        private int counter;

        public Invoice()
        {
            invoiceLines = new InvoiceLine[10];

        }

        public void AddLinie(InvoiceLine i)
        {
            invoiceLines[counter] = i;
            counter++;
        }

    }
}
