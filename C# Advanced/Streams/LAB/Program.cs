﻿using System;
using System.IO;

namespace LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader("Program.cs"))
            {
                var lineNumber = 1;
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine($"Line {lineNumber}: {line}");
                    lineNumber++;
                }
            }
        }
    }
}
