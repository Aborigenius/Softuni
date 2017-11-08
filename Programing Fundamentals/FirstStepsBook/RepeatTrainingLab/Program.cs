using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatTrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double heightInCM = height * 100;
            double widthInCM = width * 100;

            double areaInCM = heightInCM * widthInCM;
            double rows = Math.Truncate(heightInCM / 120);
            double columns = Math.Truncate((widthInCM - 100) / 70);
            double seats = rows * columns - 3;

            Console.WriteLine(seats);
        }
    }
}
