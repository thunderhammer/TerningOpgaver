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

            A[] array = new A[3];
            array[0] = new A();
            array[1] = new B();
            array[2] = new C();
            foreach (var item in array)
            {
                item.
            }
            
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
