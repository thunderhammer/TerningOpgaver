using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invoice
            // Customer
            // Invoice lines
            Customer c = new Customer() { CustomerID = 1, Name = "Jens Hansen" };
            Invoice i = new Invoice();
            i.Dato = DateTime.Now;
            i.FakturaNummer = 1;
            i.Customer = c;

            InvoiceLine l1 = new InvoiceLine { Antal = 2, Pris = 100, Tekst = "abc" };
            i.AddLinie(l1);
            i.AddLinie(new InvoiceLine { Antal = 3, Pris = 50, Tekst = "dfg" });

            //Console.WriteLine(i.invoice)

        }
    }
}
