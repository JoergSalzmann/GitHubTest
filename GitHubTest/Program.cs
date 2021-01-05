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
            Console.WriteLine("Hier wird weiterentwicklet1a");
            Console.WriteLine("Hier wird weiterentwicklet2b");
            Console.WriteLine("Hier wird weiterentwicklet3c");
            Console.WriteLine("Hier wird weiterentwicklet4d");
            Console.WriteLine("Hier wird weiterentwicklet5ef");

            //Firmen-PC
            //Home-PC
            //Firmen-NB
            //Home-NB

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
            Console.WriteLine("bugfix!");
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
