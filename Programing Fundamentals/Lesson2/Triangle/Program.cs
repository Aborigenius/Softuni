﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        //area = a * h / 2. Закръглете резултата до 2 знака след десетичната точка използвайки Math.Round(area, 2)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = (a * h / 2);
            var result = Math.Round(area, 2);

            Console.WriteLine("Triangle area = " + result);

                            
        }
    }
}
