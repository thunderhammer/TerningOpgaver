using System;
using System.IO;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            Console.WriteLine("Hello World!");
            w.Created += OnChanged;
            w.Deleted += (s, e) =>
            {
                Console.WriteLine("Deleted");
            }
            ;


            while (true) { }


        }


        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Fil rettet");
            //throw new NotImplementedException();
        }
    }
}
