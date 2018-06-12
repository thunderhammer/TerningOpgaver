using System;


namespace Delegate_test
{
    class Program
    {

        delegate void MinDelegateVoid();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MinDelegateVoid f1 = new MinDelegateVoid(Test1);
            Test1();
            f1.Invoke();
            KaldNÅrErFærdig(1,2,f1);
        }


        static void Test1()
        {
            Console.WriteLine("I test1");      
        }

        static void Test2(string txt)
        {
            Console.WriteLine("I test 2 - modtaget");
        }

        static void KaldNÅrErFærdig (int a, int b, MinDelegateVoid freferance)
        {
            // bla
            freferance.Invoke();
        }
    }
}
