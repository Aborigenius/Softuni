using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsNumber = int.Parse(Console.ReadLine());
            var totalGrades = 0.00;
            var totalStudents = 0;
            double top = 0;
            double four = 0;
            double three = 0;
            double fail = 0;

            for (int i = 0; i < studentsNumber; i++)
            {
               var grade = double.Parse(Console.ReadLine());
                totalGrades += grade;
                if (grade > 1.99 && grade <= 2.99)
                {
                    fail++;
                }
                if (grade > 2.99 && grade <= 3.99)
                {
                    three++;
                }
                if (grade > 3.99 && grade <= 4.99)
                {
                    four++;
                }
                if (grade > 4.99 && grade <= 6)
                {
                    top++;
                }
                totalStudents++;
            }

            //var totalFail = fail / totalStudents * 100;
            // Console.WriteLine($"{totalFail:f2}");
            Console.WriteLine($"{top / totalStudents * 100:F2}%");
            Console.WriteLine($"{three / totalStudents * 100:F2}%");
            Console.WriteLine($"{four / totalStudents * 100:F2}%");
            Console.WriteLine($"{fail / totalStudents * 100:F2}%");
            Console.WriteLine($"{totalGrades /totalStudents:F2}");

        }
    }
}
