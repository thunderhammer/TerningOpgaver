using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractice
{
    class Program
    {
        static void Main(string[] args)
        {            
            BestPracticeClass b = new BestPracticeClass();
            b.Felt3 = 10;
            // b.Felt5 = 10; Fails because it is a private set property

            // Calls a static method (on the type)
            BestPracticeClass.Test3();
        }
    }

    internal class BestPracticeClass // Internal is the default scope for a class, only visible within the project
    {
        // Fields
        private int felt1; // Only accessible from within the class
        public int felt2; // Globally accessible, which we should try our best to avoid. Use properties or alternatively, get/set methods as in JAVA

        // Properties (full property, propfull)
        private int felt3;

        public int Felt3
        {
            // For getting log, validation and security
            get { return felt3; }
            set { felt3 = value; }
        }

        public int Felt4 { get; set; } // Automatic property, only accesses the field. Should be changed if logic is added. 

        // Mixed types

        public int Felt5 { get; private set; } // Set could only be accessed within the class


        // Constructors

        //Default (ctor)
        public BestPracticeClass()
        {
            // Initialization code
        }

        // One or more Custom constructors
        public BestPracticeClass(int felt1)
        {
            this.felt1 = felt1; // Initialization
        }

        public BestPracticeClass(int felt1, int felt2)
        {
            this.felt1 = felt1; // Initialization
            this.felt2 = felt2;
        }

        // Methods
        public void Test1()
        {
            // The method is accessible from the outside 
            Console.WriteLine(this.felt1);
        }

        private void Test2()
        {
            // The method is accessible from the outside 
            Console.WriteLine(this.felt2);
        }

        public static void Test3()
        {
            // Static method, accessible on the type, not an object 
        }
    }
}
