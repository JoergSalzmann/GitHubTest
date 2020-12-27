using System;

namespace GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test();
            NewFunctions();
            Console.WriteLine("Last change today");
            Console.WriteLine("Änderung am Firmen-PC");
        }

        static void Test()
        {
            Console.WriteLine("This is a test programm");
            int x = 5 - 3;
            Console.WriteLine("5 - 3 = " + x);
        }

        static void NewFunctions()
        {
            Console.WriteLine("New functions");
            Console.WriteLine("Noch eine Änderung");
        }
    }
}
