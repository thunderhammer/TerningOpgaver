using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 syntakser
            int[] a = { 25, 4, 2, 4, 0, 1, 6, 14, 6 };


            //SQL-lign
            var res1 = from i in a where i < 10 select i;

            // Function style
            var res2 = a.Where((i) => { return i < 10; });
            var res3 = a.Where(i => i < 10); // uses a lambda

            var res4 = from i in a where i < 10 orderby uint select i;
            var res5 = a.Where(i => i < 10).OrderBy(i => i);

            int m = a.Min(); // The smallest in the array
            int ma = a.Max();
            int s = a.Sum();

            var res7 = a.OrderBy(i => i).GroupBy(i => i);
                        

            Console.WriteLine("Hello World!");
          
        }
    }
}
