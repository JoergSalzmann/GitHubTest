﻿using System;

namespace GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test();
            NewFunctions();
        }

        static void Test()
        {
            Console.WriteLine("This is a test programm");
            int x = 5 - 3;
            Console.WriteLine("5 - 2 = " + x);
        }

        static void NewFunctions()
        {
            Console.WriteLine("New functions");
        }
    }
}
