﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

           minutes += 30;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            if (hours == 24)
            {
                hours = 00;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");

        }
    }
}
