using System;

namespace More_Delegates_Task
{
    class Program
    {
        public static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }

        static void Main(string[] args)
        {
            Maskine a = new Maskine();
            a.skriv = Console.WriteLine;
            a.skriv += AppendLog;
            a.Start();
            a.Stop();

            /*a.skriv = new timeDelegate(Console.Write);
            a.Start();
            a.Stop(); */

        }
    }

   
    public delegate void timeDelegate(string t);


    class Maskine
    {
        public timeDelegate skriv { get; set; }
        public void Start()
        {            
            skriv(DateTime.Now.ToLongTimeString() + " " + "Starter");
            
        }

        public void Stop()
        {
            skriv(DateTime.Now.ToLongTimeString() + " " + "Stopper");
        }

    }
}
