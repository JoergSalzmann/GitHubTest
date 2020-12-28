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
            Console.WriteLine("Änderung am Firmen-PC Nummer 2");

            string Text123 = "info";

            Console.WriteLine("This is an inline '" + Text123 + "' TEST");
            Console.WriteLine($"This is an inline '{Text123}' TEST");
            Console.WriteLine("neues feature und noch eine Entwicklung");

            Tauschen(); 
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
            Console.WriteLine("Maintenance! noch einen Fehler behoben! Fehler Nummer 3!");
        }

        static void Tauschen()
        {
            var a = 1;
            var b = 2;
            Console.WriteLine(a + " - " + b);
            (a, b) = (b, a);
            Console.WriteLine(a + " - " + b);
        }
    }
}
