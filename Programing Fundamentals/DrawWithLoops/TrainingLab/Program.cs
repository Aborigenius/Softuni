using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Едно работно място заема 70 на 120 cm 
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var widthCm = (w * 100) - 100;
            var heightCm = h * 100;

            var desks = Math.Floor( widthCm / 70);
            var col = Math.Floor(heightCm / 120);

            var total = (desks * col) - 3;
            Console.WriteLine(total);
        }
    }
}
