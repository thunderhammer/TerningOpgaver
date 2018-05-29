using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejldhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = null;
                s.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Watchtower");
            }



        }
    }
}
