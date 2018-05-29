using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTestInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.MetodeA();
            B b = new B();
            A aa = new C();
            b.MetodeA();
            b.MetodeB();
            B bb = (B)aa; // Typecasting to access the methods of B

            

            
            
            


        }
        class A
        {
            public void MetodeA() { }
        }
        class B : A
        {
            public void MetodeB() { }
        }

        class C : A { }

        class D { }
    }
}
