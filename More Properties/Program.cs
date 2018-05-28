using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Properties
{
    class Person
    {
        public string Fornavn { get; set; } // Sets the string with automatic methods, easy way. 

        private string efternavn;
        public string Efternavn
        {
            get
            { return efternavn;
            }

            set
            { if (value.Length > 3)
                    this.efternavn = "";
                else efternavn = value;
            }
        }

     public string FuldtNavn()
        {

            return Fornavn + " " + Efternavn;
        } 

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1= new Person();
            p1.Efternavn = "Hansen";
            p1.Fornavn = "Jens";
            Console.WriteLine(p1.FuldtNavn());
        }
    }
}
