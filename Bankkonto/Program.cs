using System;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bankkonto b = new Bankkonto() { MinimumSaldo = -100 };
            b.SaldoUnderMinReference = new SaldoUnderMinDelegate(SaldoFejlMetode);
            b.SaldoUnderMinReference += FejltilFinansFor;                       
            b.SætInd(100);
            b.TrækUd(50);
            b.TrækUd(200);


        }

        static void SaldoFejlMetode()
        {
            Console.WriteLine("Fejl i saldo!!!");
        }

        static void FejltilFinansFor()
        {
            Console.WriteLine("Ring til finansforbundet");
        }

        public class Bankkonto
        {
            public double MinimumSaldo { get; set; }
            private double saldo;
            public SaldoUnderMinDelegate SaldoUnderMinReference { get; set; }


           

            public void SætInd(double Postering)
            {
                saldo = saldo + Postering;
            }

            public void TrækUd(double postering)
            {
                saldo = saldo - postering;
                if (saldo < MinimumSaldo)
                {
                    if (SaldoUnderMinReference != null)
                        SaldoUnderMinReference.Invoke();
                    //Console.WriteLine("Pas på saldo er " + saldo);
                }
            }
        }

        public delegate void SaldoUnderMinDelegate();

    }
}
